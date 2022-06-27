using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace L1
{   
    /// <summary>
    /// SqlEngine is a helper class using to do some frequently action like
    /// Select, Insert, Update, Delete
    /// Support select with sepcified field.
    /// 
    /// v1.0: 
    /// - Don't support join query
    /// - Don't support update specified field
    /// - 
    /// </summary>
    /// <typeparam name="TRecord"></typeparam>
    public class TableEngine<TRecord> where TRecord : BaseRecord, new()
    {       
        private string _tableName;
        private Dictionary<string, SqlDbType> _paramTypes;

        internal TableEngine()
        {
            var recordType = typeof(TRecord);
            var dbTableAttr = (L1.Attributes.DbTableAttribute)recordType.GetCustomAttributes(typeof(L1.Attributes.DbTableAttribute), false)[0];            
            this._tableName = dbTableAttr.Name.ToLower();
            L1.Logger.LogLevel2("Table [" + this._tableName + "]:");            
            // map fields
            _paramTypes = new Dictionary<string, SqlDbType>();
            var propsInfo = recordType.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propInfo in propsInfo)
            {
                var propAttrs = propInfo.GetCustomAttributes(typeof(L1.Attributes.DbFieldAttribute), true);
                if (propAttrs.Length != 1)
                    continue;

                var dbFieldAttr = propAttrs[0] as L1.Attributes.DbFieldAttribute;
                if (string.IsNullOrEmpty(dbFieldAttr.Name))
                {
                    L1.Logger.LogLevel2("\t* DbFieldAttribute name is blank or empty.");
                    throw new Exception("Missing DbFieldAttribute Name");
                }
                else
                {
                    // cache param type
                    var paramName = "@" + dbFieldAttr.Name.ToLower();                    
                    _paramTypes[paramName] = dbFieldAttr.Type;
                    L1.Logger.LogLevel2("\t* [" + paramName + "] " + dbFieldAttr.Type);
                }
            }
        }

        //--
        public List<TRecord> Select(List<BaseField> where = null)
        {
            L1.Logger.LogLevel3("Execute T-SQL table [" + this._tableName + "] Select cmd");
            _enrichCondition(where);
            var selectCondition = _buildCondition(where);
            var cmd = "SELECT * FROM " + _tableName + selectCondition.Item1;
            var @params = selectCondition.Item2;
            _updateFieldType(@params);
            var records = new List<TRecord>();
            SqlHelper.ExecuteReader((dr) => 
            {
                TRecord record;
                while (!dr.IsClosed && dr.Read())
                {
                    record = new TRecord();
                    record.Parse(dr);
                    records.Add(record);
                }
            }, cmd, @params);

            return records;
        }

        /// <summary>
        /// Select with specified field
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<TRecord> SelectFields(List<string> fields, List<BaseField> where = null)
        {
            L1.Logger.LogLevel3("Execute T-SQL table [" + this._tableName + "] SelectFields cmd");
            _enrichCondition(where);
            var selectCondition = _buildCondition(where);
            var ieFields = fields.Select((item) => "[" + item + "]");
            var columns = string.Join(",", ieFields.ToArray());
            var cmd = "SELECT " + columns + " FROM " + _tableName + selectCondition.Item1;
            var @params = selectCondition.Item2;
            var records = new List<TRecord>();
            TRecord record;
            _updateFieldType(@params);
            SqlHelper.ExecuteReader((dr) =>
            {                
                // reader close 
                while (!dr.IsClosed && dr.Read())
                {
                    record = new TRecord();
                    record.Parse(dr);
                    records.Add(record);
                }
            }, cmd, @params);
            return records;
        }

        /// <summary>
        /// Return total number of record which match with condition
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int Count(List<BaseField> where = null)
        {
            L1.Logger.LogLevel3("Execute T-SQL table [" + this._tableName + "] Count cmd");
            _enrichCondition(where);
            var builtCondition = _buildCondition(where);
            var cmd = "SELECT Count(*) FROM " + _tableName + builtCondition.Item1;
            var @params = builtCondition.Item2;
            _updateFieldType(@params);
            int rs = SqlHelper.ExecuteScalar<int>(cmd, @params);
            return rs;
        }

        /// <summary>
        /// Insert item to table and return inserted id
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Insert(List<BaseField> data)
        {
            L1.Logger.LogLevel3("Execute T-SQL table [" + this._tableName + "] Insert cmd");
            if (data == null|| data.Count == 0)
                return 0;

            var columnNames = new List<string>();
            var paramNames = new List<string>();
            var sqlParams = new List<SqlParameter>();

            foreach (var item in data)
            {
                // skip id
                if (string.Compare(item._name.ToLower(), "id", true) == 0)
                    continue;

                // put name in square to prevent preverse keyword of SQL
                columnNames.Add("[" + item._name.ToLower() + "]");
                paramNames.Add(item._name.ToLower());
                sqlParams.AddRange(item._param);
            }

            string cmd = string.Format(
                "INSERT INTO {0}({1}) OUTPUT INSERTED.Id VALUES(@{2})", 
                _tableName, 
                string.Join(",", columnNames), 
                string.Join(",@", paramNames));
            // cause we return output is integer so we call ExecuteScalar

            _updateFieldType(sqlParams);
            int rs = SqlHelper.ExecuteScalar<int>(cmd, sqlParams.ToArray());
            return rs;
        }

        /// <summary>
        /// Update and return affected records
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Update(List<BaseField> fields, List<BaseField> where)
        {
            L1.Logger.LogLevel3("Execute T-SQL table [" + this._tableName + "] Update cmd");
            // no thing update
            if (fields == null || fields.Count == 0)
                return 0;

            // build column and param
            var columns = new List<string>();
            var @params = new List<SqlParameter>();
            foreach (var item in fields)
            {
                // skip id
                if (string.Compare(item._name, "id", true) == 0)
                    continue;

                columns.Add(item._name.ToLower());
                @params.AddRange(item._param);
            }
            var sets = new List<string>();
            for (int i = 0; i < columns.Count; i++)
                sets.Add(string.Format("[{0}] = {1}", columns[i], @params[i].ParameterName));

            var builtCondition = _buildCondition(where);
            var cmd = string.Format(
                "UPDATE {0} SET {1} {2}", 
                _tableName, 
                string.Join(",", sets.ToArray()), 
                builtCondition.Item1);

            @params.AddRange(builtCondition.Item2);
            _updateFieldType(@params);
            int rs = SqlHelper.ExecuteNonQuery(cmd, @params.ToArray());
            return rs;
        }

        /// <summary>
        /// Delete item matched with condition
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Delete(List<BaseField> where)
        {
            L1.Logger.LogLevel3("Execute T-SQL table [" + this._tableName + "] Delete cmd");
            var builtCondition = _buildCondition(where);
            var cmd = "DELETE " + _tableName + builtCondition.Item1;
            var @params = builtCondition.Item2;
            _updateFieldType(@params);
            int rs = SqlHelper.ExecuteNonQuery(cmd, @params);
            return rs;
        }

        // --
        private void _enrichCondition(List<BaseField> fields)
        {
            if (fields == null)
                fields = new List<BaseField>();            
        }
        private void _updateFieldType(List<SqlParameter> @params)
        {
            L1.Logger.LogLevel3("Update field type List<>");
            if (@params == null || @params.Count == 0)
            {
                L1.Logger.LogLevel3("\tNo param.");
                return;
            }

            foreach (var param in @params)
            {
                if (_paramTypes.ContainsKey(param.ParameterName.ToLower()))
                {
                    param.SqlDbType = _paramTypes[param.ParameterName.ToLower()];
                    L1.Logger.LogLevel3("\t* Set param type of [" + param.ParameterName + "] to [" + param.SqlDbType + "]");
                }
                else
                {
                    L1.Logger.LogLevel3("\t* Not found [" + param.ParameterName + "] in parameters cache.");
                }
            }
        }
        private void _updateFieldType(SqlParameter[] @params)
        {
            L1.Logger.LogLevel3("Update field type []");
            if (@params == null || @params.Length == 0)
            {
                L1.Logger.LogLevel3("\tNo param.");
                return;
            }

            foreach (var param in @params)
            {
                if (_paramTypes.ContainsKey(param.ParameterName.ToLower()))
                {
                    param.SqlDbType = _paramTypes[param.ParameterName.ToLower()];
                    L1.Logger.LogLevel3("\t* Set param type of [" + param.ParameterName + "] to [" + param.SqlDbType + "]");
                }
                else
                {
                    L1.Logger.LogLevel3("\t* Not found [" + param.ParameterName + "] in parameters cache.");
                }
            }
        }
        
        // --
        private Tuple<string, SqlParameter[]> _buildCondition(List<BaseField> condition)
        {
            L1.Logger.LogLevel3("Building T-SQL condition.");

            var conditionStrOutput = string.Empty;
            var sqlParams = new List<SqlParameter>();

            if (condition != null && condition.Count != 0)
            {
                L1.Logger.LogLevel3("Detect at least 1 condition.");

                var where = condition.Count > 0 ? " WHERE " : string.Empty;
                var conditionStrs = new List<string>();
                foreach (var item in condition)
                {
                    // TODO : Add more field type here
                    if (item is NullField)
                    {                        
                        conditionStrs.Add(string.Format("[{0}] is null", item._name.ToLower()));
                        L1.Logger.LogLevel3("Null condition added with name [" + item._name.ToLower() + "]");
                    }
                    else
                    {
                        if (item is EqField)
                        {                            
                            conditionStrs.Add(string.Format("[{0}] = {1}", item._name.ToLower(), item._param[0].ParameterName.ToLower()));
                            L1.Logger.LogLevel3("Equal condition added with name [" + item._name.ToLower() + "] and param value [" + item._param[0].Value + "]");
                        }
                        else if (item is NEqField)
                        {
                            conditionStrs.Add(string.Format("[{0}] <> {1}", item._name.ToLower(), item._param[0].ParameterName.ToLower()));
                            L1.Logger.LogLevel3("Un-equal condition added with name [" + item._name.ToLower() + "] and param value [" + item._param[0].Value + "]");
                        }
                        else if (item is InField)
                        {
                            List<string> paramNames = new List<string>();
                            foreach (var par in item._param)
                                paramNames.Add(par.ParameterName.ToLower());
                            var list = string.Join(",", paramNames.ToArray());
                            conditionStrs.Add(string.Format("[{0}] IN ({1})", item._name, list));
                            L1.Logger.LogLevel3("In condition added with name [" + item._name.ToLower() + "] and param value [(" + list + ")]");
                        }

                        sqlParams.AddRange(item._param); // add condition value
                    }
                }
                conditionStrOutput = where + string.Join(" AND ", conditionStrs.ToArray());
            }
            else
            {
                L1.Logger.LogLevel3("No condition.");
            }

            return new Tuple<string, SqlParameter[]>(conditionStrOutput, sqlParams.ToArray());
        }
    }
}