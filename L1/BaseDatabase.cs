using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace L1
{
    public class BaseDatabase
    {
        private Dictionary<Type, IBaseTable> _tables;        
        protected BaseDatabase(string dbSource, string dbName, string username, string password)
        {
            Logger.LogLevel1("Initialize connection to SQLServer database [" + dbName + "] at source [" + dbSource+ "]");
            // init sql helper
            SqlHelper.InitSqlHelper(dbSource, dbName, username, password);

            // Table mapping
            Logger.LogLevel1("Tables mapping...");
            _tables = new Dictionary<Type, IBaseTable>();

            var types = Assembly.GetCallingAssembly().GetTypes();
            foreach (var type in types)
            {
                var dbTableAttrs = type.GetCustomAttributes(typeof(L1.Attributes.DbTableAttribute), false);
                if (dbTableAttrs.Length == 0)
                    continue;

                var dbTableAttr = dbTableAttrs[0] as L1.Attributes.DbTableAttribute;
                if (dbTableAttr != null)
                {
                    // create mapping to real db table
                    var tableType = typeof(L1.BaseTable<>).MakeGenericType(new Type[] { type });
                    _tables[type] = Activator.CreateInstance(tableType) as IBaseTable;
                }
            }
            Logger.LogLevel1("Mapping tables in SQLServer database completed.");
        }

        public BaseTable<T> Table<T>() where T : BaseRecord, new()
        {
            if (_tables.ContainsKey(typeof(T)))
                return (BaseTable<T>)_tables[typeof(T)];
            return null;
        }
    }
}
