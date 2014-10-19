using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4DB2
{
    /// <summary>
    /// Title: DatabaseConnection
    /// Descr: Utility class for database connections
    /// Autor: Pellegrini Roland
    /// Note : System.configuration muss in VisualStudio unter References hinzugefügt werden
    /// </summary>
    // public SimpleDatabaseConnection() : this(ConfigurationManager.ConnectionStrings["Tax.Properties.Settings.TaxConnectionString"].ConnectionString )
    // public SimpleDatabaseConnection(System.Configuration.ConfigurationManager manager)
    //    : this(System.Configuration.ConfigurationManager.ConnectionStrings["Tax.Properties.Settings.TaxConnectionString"].ConnectionString)
    public class DatabaseConnection
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private string _connectionString;
        /// <summary>
        /// 
        /// </summary>
        private System.Data.SqlClient.SqlConnection _sqlConnection;
        /// <summary>
        /// 
        /// </summary>
        private System.Data.SqlClient.SqlCommand _sqlCommand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private System.Data.SqlClient.SqlDataReader _sqlDataReader;
        /// <summary>
        /// 
        /// </summary>
        private System.Data.SqlClient.SqlDataAdapter _sqlDataAdapter;
        /// <summary>
        /// 
        /// </summary>
        private System.Data.SqlClient.SqlBulkCopy _sqlBulkCopy;
        /// <summary>
        /// 
        /// </summary>
        private System.Data.DataSet _dataSet { get; set; }

        #endregion //Fields
        
        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
            _sqlConnection = new System.Data.SqlClient.SqlConnection(_connectionString);
        }

        #endregion // Constructors

        #region Public Methods

        /// <summary>
        /// Connect to the database
        /// </summary>
        /// <returns>SqlConnection</returns>
        public System.Data.SqlClient.SqlConnection Connect()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed || _sqlConnection.State == System.Data.ConnectionState.Broken)
            {
                _sqlConnection.Open();
            }
            return _sqlConnection;
        }

        /// <summary>
        /// Disconnect from the database
        /// </summary>
        /// <returns>SqlConnection</returns>
        public System.Data.SqlClient.SqlConnection Disconnect()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
            return _sqlConnection;
        }

        /// <summary>
        /// Check if database is online
        /// </summary>
        /// <returns></returns>
        public bool IsAlive()
        {
            return (DatabaseConnection.IsAlive(this._connectionString));
        }

        /// <summary>
        /// Check if database is online
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static bool IsAlive(string connectionString)
        {
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand cmd;
            try
            {
                sqlConnection.Open();
                cmd = new System.Data.SqlClient.SqlCommand("Select 1", sqlConnection);
                int resultset = cmd.ExecuteNonQuery();
                cmd = null;
                sqlConnection.Close();
                if (resultset != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cmd = null;
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strQueryCommand"></param>
        /// <returns></returns>
        public System.Data.DataTable ReturnDataTable(string sqlQueryCommand)
        {
            _sqlCommand = new System.Data.SqlClient.SqlCommand();
            try
            {
                _sqlCommand.Connection = Connect();
                _sqlCommand.CommandText = sqlQueryCommand;
                _sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(_sqlCommand);
                System.Data.DataTable dt = new System.Data.DataTable();
                _sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _sqlCommand = null;
                Disconnect();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strQueryCommand"></param>
        /// <returns></returns>
        public System.Data.DataSet ReturnDataSet(string sqlQueryCommand)
        {
            try
            {
                Connect();
                _sqlCommand = _sqlConnection.CreateCommand();
                _sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlQueryCommand, _sqlConnection);
                _dataSet = new System.Data.DataSet();
                _dataSet.Reset();
                _sqlDataAdapter.Fill(_dataSet);
                return _dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _sqlCommand = null;
                Disconnect();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlQueryCommand"></param>
        public void ExecuteQuery(string sqlQueryCommand)
        {
            try
            {
                Connect();
                _sqlCommand = _sqlConnection.CreateCommand();
                _sqlCommand.CommandText = sqlQueryCommand;
                _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _sqlCommand = null;
                Disconnect();
            }

        }
        /// <summary>
        /// call datareader 
        /// 
        /// ich habe für den datareader bis heute 
        /// noch keinen verzwendungszweck gefunden,
        /// daher kommentieren wir die gesamte 
        /// methode mal aus
        /// 
        /// </summary>
        /// <param name="strQueryCommand"></param>
        /// <returns></returns>
        /*
        public SqlDataReader ReturnDataReader(string sqlQueryCommand)
        {
            try
            {
                Connect();
                _sqlCommand = _sqlConnection.CreateCommand();
                _sqlCommand.CommandText = sqlQueryCommand;
                _sqlDataReader = _sqlCommand.ExecuteReader();
                return _sqlDataReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
                _sqlCommand = null;
            }
        } */

        /// <summary>
        /// Return a SqlAdapter
        /// </summary>
        /// <param name="sqlQueryCommand"></param>
        /// <returns></returns>
        public System.Data.SqlClient.SqlDataAdapter GetSqlDataAdapter(string sqlQueryCommand)
        {
            try
            {
                System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(sqlQueryCommand, _sqlConnection);
                return adapter;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public void InsertDataTable(string tableName, System.Data.DataTable dataTable)
        {
            try
            {
                Connect();
                _sqlBulkCopy = new System.Data.SqlClient.SqlBulkCopy(
                                _sqlConnection, System.Data.SqlClient.SqlBulkCopyOptions.TableLock | 
                                System.Data.SqlClient.SqlBulkCopyOptions.FireTriggers | 
                                System.Data.SqlClient.SqlBulkCopyOptions.UseInternalTransaction, null);
                _sqlBulkCopy.DestinationTableName = tableName;
                _sqlBulkCopy.WriteToServer(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _sqlBulkCopy = null;
                Disconnect();
            }
        }

        #endregion // Public Methods

    } // end class
} // namespace

