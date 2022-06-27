using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace L1.Attributes
{
    /// <summary>
    /// Mark a property as a db field
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DbFieldAttribute : Attribute
    {
        public string Name { get; private set; }
        public SqlDbType Type { get; private set; }
        public object DefaultValue { get; set; }

        public DbFieldAttribute(string columnName, SqlDbType columnType)
            : base()
        {
            Name = columnName;
            Type = columnType;
        }
    }
}
