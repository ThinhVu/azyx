using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace L1
{
    public abstract class BaseField
    {
        internal string _name;
        internal SqlParameter[] _param;
    }

    /// <summary>
    /// No need param
    /// </summary>
    public class NullField : BaseField
    {        
        public NullField(string name)
        {
            _name = name.ToLower();
            _param = new SqlParameter[0];
        }
    }

    /// <summary>
    /// Indicate SQL equal compare
    /// Param type will be auto mapping by sql engine
    /// </summary>
    public class EqField : BaseField
    {      
        public EqField(string name, object value)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("name cannot be null");
            _name = name.ToLower();
            _param = new SqlParameter[1] {
                new SqlParameter("@" + name.ToLower(), value)
            };
        }
    }

    /// <summary>
    /// Indicate SQL not equal compare
    /// Param type will be auto mapping by sql engine
    /// </summary>
    public class NEqField : BaseField
    {
        public NEqField(string name, object value)
        {
            _name = name.ToLower();
            _param = new SqlParameter[1] {
                new SqlParameter("@" + name.ToLower(), value)
            };
        }
    }

    /// <summary>
    /// Indicate SQL In compare
    /// Param type won't be auto mapping
    /// </summary>
    public class InField : BaseField
    {
        private static int _index;
        public InField(string name, List<object> values, SqlDbType type)
        {
            _name = name.ToLower();
            if (values == null)
                _param = new SqlParameter[0];
            else 
                _param = new SqlParameter[values.Count];

            for (int i = 0; i < values.Count; i++)
            {
                _index++;
                _param[i] = new SqlParameter("@" + name.ToLower() + _index, type) { Value = values[i] }; 
            }
        }
    }
}
