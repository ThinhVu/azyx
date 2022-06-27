using System;
using System.Data;
using System.Data.SqlClient;

namespace L1
{    
    public static class SqlHelper
    {
        // cache connection string
        private static string _connectionString;

        /// <summary>
        /// Init sql helper
        /// </summary>
        /// <param name="dbSource"></param>
        /// <param name="dbName"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void InitSqlHelper(string dbSource, string dbName, string username, string password)
        {            
            _connectionString = string.Format(
               "Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
               dbSource,
               dbName,
               username,
               password);
        }
        
        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] @params)
        {            
            // insert, delete, update
            return _do((sqlConnection) =>
            {
                Logger.LogLevel2("ExecuteNonQuery:");
                Logger.LogLevel2("\t• Cmd Text: "+ cmdText);
                Logger.LogLevel2("\t• Parameters : ");
                foreach (var param in @params)
                {
                    Logger.LogLevel2("\t\t > " + param.ParameterName + " = " + param.Value); 
                }
                var cmd = new SqlCommand();
                cmd.CommandText = cmdText;
                cmd.Connection = sqlConnection;
                cmd.Parameters.AddRange(@params);
                return cmd.ExecuteNonQuery();
            });
        }
        public static TResult ExecuteScalar<TResult>(string cmdText, params SqlParameter[] @params)
        {
            return _do((sqlConnection) =>
            {
                Logger.LogLevel2("ExecuteScalar");
                Logger.LogLevel2("\t• Cmd Text: " + cmdText);
                Logger.LogLevel2("\t• Parameters : ");
                foreach (var param in @params)
                {
                    Logger.LogLevel2("\t\t > " + param.ParameterName + " = " + param.Value);
                }
                var cmd = new SqlCommand();
                cmd.CommandText = cmdText;
                cmd.Connection = sqlConnection;
                cmd.Parameters.AddRange(@params);
                object o = cmd.ExecuteScalar();
                return (TResult)o;
            });
        }
        public static void ExecuteReader(Action<SqlDataReader> readAction, string cmdText, params SqlParameter[] @params)
        {
            _do((sqlConnection) =>
            {
                Logger.LogLevel2("ExecuteReader");
                Logger.LogLevel2("\t• Cmd Text: " + cmdText);
                Logger.LogLevel2("\t• Parameters : ");
                foreach (var param in @params)
                {
                    Logger.LogLevel2("\t\t > " + param.ParameterName + " = " + param.Value);
                }
                var cmd = new SqlCommand();
                cmd.CommandText = cmdText;
                cmd.Connection = sqlConnection;
                cmd.Parameters.AddRange(@params);
                var reader = cmd.ExecuteReader();
                readAction(reader);
                reader.Close();
            });
        }  

        // --
        private static void _do(Action<SqlConnection> action)
        {
            SqlConnection sqlConnection = null;
            bool connectionEstablished = false;
            try
            {
                sqlConnection = _createSqlConnection();
                sqlConnection.Open();
                connectionEstablished = true;
            }
            catch (Exception ex)
            {
                Logger.LogLevel3(string.Format(
                        "Exception:{0}\tMessage: {1}{0}\tStackTrace: {2}",
                        Environment.NewLine, ex.Message, ex.StackTrace));
                throw ex;
            }

            if (!connectionEstablished) return;

            try
            {
                action(sqlConnection);
            }
            catch (Exception ex)
            {
                Logger.LogLevel2(string.Format(
                        "Exception:{0}\tMessage: {1}{0}\tStackTrace: {2}",
                        Environment.NewLine, ex.Message, ex.StackTrace));
                throw ex;
            }
            finally
            {
                try
                {
                    _closeConnection(sqlConnection);
                }
                catch (Exception ex2)
                {
                     Logger.LogLevel2(string.Format(
                        "Exception:{0}\tMessage: {1}{0}\tStackTrace: {2}",
                        Environment.NewLine, ex2.Message, ex2.StackTrace));
                }
            }
        }
        private static TResult _do<TResult>(Func<SqlConnection, TResult> function)
        {
            TResult rs = default(TResult);
            SqlConnection sqlConnection = null;
            bool connectionEstablished = false;
            try
            {
                sqlConnection = _createSqlConnection();
                sqlConnection.Open();
                connectionEstablished = true;
            }
            catch (Exception ex)
            {
                Logger.LogLevel3(string.Format(
                        "Exception:{0}\tMessage: {1}{0}\tStackTrace: {2}",
                        Environment.NewLine, ex.Message, ex.StackTrace));
                throw ex;
            }

            if (!connectionEstablished) return rs;

            try
            {                
                rs = function(sqlConnection);
            }
            catch (Exception ex)
            {
                Logger.LogLevel2(string.Format(
                        "Exception:{0}\tMessage: {1}{0}\tStackTrace: {2}",
                        Environment.NewLine, ex.Message, ex.StackTrace));
                throw ex;
            }
            finally
            {
                try
                {
                    _closeConnection(sqlConnection);
                }
                catch (Exception ex2)
                {
                    Logger.LogLevel3(string.Format(
                        "Exception:{0}\tMessage: {1}{0}\tStackTrace: {2}",
                        Environment.NewLine, ex2.Message, ex2.StackTrace));
                }                
            }

            return rs;
        }
        // --
        private static SqlConnection _createSqlConnection()
        {
            L1.Logger.LogLevel3("SQL connection establishing...");
            var conn = new SqlConnection(_connectionString);
            L1.Logger.LogLevel3("SQL connection established.");
            return conn;
        }
        private static void _closeConnection(SqlConnection sqlConnection)
        {
            if (sqlConnection != null && sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                L1.Logger.LogLevel3("SQL connection closing...");
                sqlConnection.Close();
                sqlConnection = null;
                L1.Logger.LogLevel3("SQL connection closed.");
            }
        }
    }
}
