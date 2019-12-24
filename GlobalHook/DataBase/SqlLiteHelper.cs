using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GlobalHook.DataBase
{
    class SqlLiteHelper
    {
        public static int GetMaxID(string FieldName, string TableName)
        {
            string sqlstring = "select max(" + FieldName + ")+1 from " + TableName;
            object single = SqlLiteHelper.GetSingle(sqlstring);
            if (single == null)
            {
                return 1;
            }
            return int.Parse(single.ToString());
        }

        public static bool Exists(string strSql)
        {
            object single = SqlLiteHelper.GetSingle(strSql);
            int result;
            if (object.Equals(single, null) || object.Equals(single, DBNull.Value))
            {
                result = 0;
            }
            else
            {
                result = int.Parse(single.ToString());
            }
            return result != 0;
        }

        public static bool Exists(string strSql, params SQLiteParameter[] cmdParms)
        {
            object single = SqlLiteHelper.GetSingle(strSql, cmdParms);
            int result;
            if (object.Equals(single, null) || object.Equals(single, DBNull.Value))
            {
                result = 0;
            }
            else
            {
                result = int.Parse(single.ToString());
            }
            return result != 0;
        }

        public static int ExecuteSql(string SQLString)
        {
            int result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(SQLString, sqliteConnection))
                {
                    try
                    {
                        sqliteConnection.Open();
                        int num = sqliteCommand.ExecuteNonQuery();
                        result = num;
                    }
                    catch (SQLiteException ex)
                    {
                        sqliteConnection.Close();
                        throw new Exception(ex.Message);
                    }
                }
            }
            return result;
        }

        public static void ExecuteSqlTran(ArrayList SQLStringList)
        {
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                sqliteConnection.Open();
                SQLiteCommand sqliteCommand = new SQLiteCommand();
                sqliteCommand.Connection = sqliteConnection;
                SQLiteTransaction sqliteTransaction = sqliteConnection.BeginTransaction();
                sqliteCommand.Transaction = sqliteTransaction;
                try
                {
                    for (int i = 0; i < SQLStringList.Count; i++)
                    {
                        string text = SQLStringList[i].ToString();
                        if (text.Trim().Length > 1)
                        {
                            sqliteCommand.CommandText = text;
                            sqliteCommand.ExecuteNonQuery();
                        }
                    }
                    sqliteTransaction.Commit();
                }
                catch (SQLiteException ex)
                {
                    sqliteTransaction.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }

        public static int ExecuteSql(string SQLString, string content)
        {
            int result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                SQLiteCommand sqliteCommand = new SQLiteCommand(SQLString, sqliteConnection);
                SQLiteParameter sqliteParameter = new SQLiteParameter("@content", DbType.String);
                sqliteParameter.Value = content;
                sqliteCommand.Parameters.Add(sqliteParameter);
                try
                {
                    sqliteConnection.Open();
                    int num = sqliteCommand.ExecuteNonQuery();
                    result = num;
                }
                catch (SQLiteException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sqliteCommand.Dispose();
                    sqliteConnection.Close();
                }
            }
            return result;
        }

        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            int result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                SQLiteCommand sqliteCommand = new SQLiteCommand(strSQL, sqliteConnection);
                SQLiteParameter sqliteParameter = new SQLiteParameter("@fs", DbType.Binary);
                sqliteParameter.Value = fs;
                sqliteCommand.Parameters.Add(sqliteParameter);
                try
                {
                    sqliteConnection.Open();
                    int num = sqliteCommand.ExecuteNonQuery();
                    result = num;
                }
                catch (SQLiteException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sqliteCommand.Dispose();
                    sqliteConnection.Close();
                }
            }
            return result;
        }

        public static object GetSingle(string SQLString)
        {
            object result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand(SQLString, sqliteConnection))
                {
                    try
                    {
                        sqliteConnection.Open();
                        object obj = sqliteCommand.ExecuteScalar();
                        if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
                        {
                            result = null;
                        }
                        else
                        {
                            result = obj;
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        sqliteConnection.Close();
                        throw new Exception(ex.Message);
                    }
                }
            }
            return result;
        }

        public static SQLiteDataReader ExecuteReader(string strSQL)
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString);
            SQLiteCommand sqliteCommand = new SQLiteCommand(strSQL, sqliteConnection);
            SQLiteDataReader result;
            try
            {
                sqliteConnection.Open();
                SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                result = sqliteDataReader;
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public static DataSet Query(string SQLString)
        {
            DataSet result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                DataSet dataSet = new DataSet();
                try
                {
                    sqliteConnection.Open();
                    SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(SQLString, sqliteConnection);
                    sqliteDataAdapter.Fill(dataSet, "ds");
                }
                catch (SQLiteException ex)
                {
                    throw new Exception(ex.Message);
                }
                result = dataSet;
            }
            return result;
        }

        public static int ExecuteSql(string SQLString, params SQLiteParameter[] cmdParms)
        {
            int result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand())
                {
                    try
                    {
                        SqlLiteHelper.PrepareCommand(sqliteCommand, sqliteConnection, null, SQLString, cmdParms);
                        int num = sqliteCommand.ExecuteNonQuery();
                        sqliteCommand.Parameters.Clear();
                        result = num;
                    }
                    catch (SQLiteException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            return result;
        }

        public static void ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                sqliteConnection.Open();
                using (SQLiteTransaction sqliteTransaction = sqliteConnection.BeginTransaction())
                {
                    SQLiteCommand sqliteCommand = new SQLiteCommand();
                    try
                    {
                        foreach (object obj in SQLStringList)
                        {
                            DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
                            string cmdText = dictionaryEntry.Key.ToString();
                            SQLiteParameter[] cmdParms = (SQLiteParameter[])dictionaryEntry.Value;
                            SqlLiteHelper.PrepareCommand(sqliteCommand, sqliteConnection, sqliteTransaction, cmdText, cmdParms);
                            sqliteCommand.ExecuteNonQuery();
                            sqliteCommand.Parameters.Clear();
                            sqliteTransaction.Commit();
                        }
                    }
                    catch
                    {
                        sqliteTransaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static object GetSingle(string SQLString, params SQLiteParameter[] cmdParms)
        {
            object result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                using (SQLiteCommand sqliteCommand = new SQLiteCommand())
                {
                    try
                    {
                        SqlLiteHelper.PrepareCommand(sqliteCommand, sqliteConnection, null, SQLString, cmdParms);
                        object obj = sqliteCommand.ExecuteScalar();
                        sqliteCommand.Parameters.Clear();
                        if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
                        {
                            result = null;
                        }
                        else
                        {
                            result = obj;
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            return result;
        }

        public static SQLiteDataReader ExecuteReader(string SQLString, params SQLiteParameter[] cmdParms)
        {
            SQLiteConnection conn = new SQLiteConnection(SqlLiteHelper.connectionString);
            SQLiteCommand sqliteCommand = new SQLiteCommand();
            SQLiteDataReader result;
            try
            {
                SqlLiteHelper.PrepareCommand(sqliteCommand, conn, null, SQLString, cmdParms);
                SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                sqliteCommand.Parameters.Clear();
                result = sqliteDataReader;
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public static DataSet Query(string SQLString, params SQLiteParameter[] cmdParms)
        {
            DataSet result;
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(SqlLiteHelper.connectionString))
            {
                SQLiteCommand sqliteCommand = new SQLiteCommand();
                SqlLiteHelper.PrepareCommand(sqliteCommand, sqliteConnection, null, SQLString, cmdParms);
                using (SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(sqliteCommand))
                {
                    DataSet dataSet = new DataSet();
                    try
                    {
                        sqliteDataAdapter.Fill(dataSet, "ds");
                        sqliteCommand.Parameters.Clear();
                    }
                    catch (SQLiteException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    result = dataSet;
                }
            }
            return result;
        }

        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, string cmdText, SQLiteParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {
                foreach (SQLiteParameter sqliteParameter in cmdParms)
                {
                    cmd.Parameters.Add(sqliteParameter);
                }
            }
        }

        public static string connectionString = ConfigurationManager.AppSettings["DBConnectionString"];
    }
}
