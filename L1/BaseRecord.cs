using L1.Attributes;
using L1.Compressors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

// Layer1
namespace L1
{
    /// <summary>
    /// Base record
    /// This class do alot of magic thing etc:
    /// + Auto empty-out string
    /// + Auto get fields
    /// + Auto set fields
    /// + Auto compress/decompress
    /// + Auto encrypt/decrypt
    /// 
    /// TODO: Implement encryptor
    /// </summary>
    public abstract class BaseRecord
    {
        [DbField("Id", SqlDbType.Int)]
        public int Id { get; set; }

        public BaseRecord()
        {
            var dbProps = GetDbProps();
            for (int i = 0; i < dbProps.Count; i++)
            {
                if (dbProps[i].PropertyType.Name == "String")
                    dbProps[i].SetValue(this, string.Empty, null);
            }
        }

        public virtual void Parse(SqlDataReader dr)
        {
            // get return fields
            var fieldNames = _getFieldNameLowers(dr);
            L1.Logger.LogLevel2("Parse field name: " + string.Join(",", fieldNames.ToArray()));
            var dbProps = GetDbProps();
            for (int i = 0; i < dbProps.Count; i++)
            {
                try
                {
                    // name of prop
                    var name = (dbProps[i].GetCustomAttributes(typeof(DbFieldAttribute), true)[0] as DbFieldAttribute).Name;
                    if (fieldNames.Contains(name.ToLower()))
                    {
                        object value = dr[name];
                        L1.Logger.LogLevel2("======================================");
                        L1.Logger.LogLevel2("name: " + name);
                        L1.Logger.LogLevel2("value: " + value);
                        L1.Logger.LogLevel2("======================================");
                        var compressors = dbProps[i].GetCustomAttributes(typeof(CompressorAttribute), true);
                        var encryptors = dbProps[i].GetCustomAttributes(typeof(EncryptorAttribute), true);

                        bool compressDecompress = compressors.Length > 0;
                        bool encryptDecrypt = encryptors.Length > 0;

                        if (compressDecompress)
                        {
                            if (compressors[0] is CompressorAttribute)
                            {
                                var compressAttr = (compressors[0] as CompressorAttribute);
                                var compressor = Activator.CreateInstance(compressAttr.CompressorType);
                                if (compressAttr.CompressorType == typeof(GzipBase64Compressor))
                                {
                                    value = (compressor as GzipBase64Compressor).Decompress((string)value);
                                }
                                // another compress go here
                            }
                        }

                        dbProps[i].SetValue(this, value, null);
                    }
                }
                catch (Exception ex)
                {                    
                    throw ex;
                }
            }
        }            
        public virtual List<BaseField> GetFields()
        {
            var fields = new List<BaseField>();
            var dbProps = GetDbProps();
            for (int i = 0; i < dbProps.Count; i++)
            {                
                var attr = (DbFieldAttribute)dbProps[i].GetCustomAttributes(typeof(DbFieldAttribute), true)[0];
                object value = dbProps[i].GetValue(this, null);
                // set default value for ... hmm field
                if (value == null)
                    value = attr.DefaultValue;

                var compressors = dbProps[i].GetCustomAttributes(typeof(CompressorAttribute), true);
                var encryptors = dbProps[i].GetCustomAttributes(typeof(EncryptorAttribute), true);

                bool compressDecompress = compressors.Length > 0;
                bool encryptDecrypt = encryptors.Length > 0;

                if (compressDecompress)
                {
                    if (compressors[0] is CompressorAttribute)
                    {
                        var compressAttr = (compressors[0] as CompressorAttribute);
                        var compressor = Activator.CreateInstance(compressAttr.CompressorType);
                        if (compressAttr.CompressorType == typeof(GzipBase64Compressor))
                        {
                            value = (compressor as GzipBase64Compressor).Compress((string)value);
                        }
                        // another compress go here
                    }
                }
                
                fields.Add(new EqField(attr.Name, value));
            }

            return fields;
        }        
        private List<PropertyInfo> GetDbProps()
        {            
            var type = this.GetType();
            var bindingFlags = 
                System.Reflection.BindingFlags.Public | 
                System.Reflection.BindingFlags.Instance;
            var allProps = (type.GetProperties(bindingFlags));
            var targetProps = new List<PropertyInfo>();
            foreach (var prop in allProps)
            {
                if (prop.GetCustomAttributes(typeof(DbFieldAttribute), true).Length > 0)
                    targetProps.Add(prop);
            }
            return targetProps;
        }


        private List<string> _getFieldNameLowers(SqlDataReader dr)
        {
            var fieldNames = new List<string>();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                fieldNames.Add(dr.GetName(i).ToLower());
            }
            return fieldNames;
        }
    }
}
