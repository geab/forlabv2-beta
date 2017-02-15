using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LQT.GUI
{
    [Serializable]
    public class ConnectionManager
    {
        private readonly IConnectionManager _connectionManager;
        private static ConnectionManager _theUniqueInstance;

        private ConnectionManager()
        {
                _connectionManager = Standard.GetInstance();
        }

        private ConnectionManager(string pLogin, string pPassword, string pServer, string pDatabase, string pTimeout, bool integrated)
        {
            _connectionManager = Standard.GetInstance(pLogin, pPassword, pServer, pDatabase, pTimeout, integrated);
        }

        public static ConnectionManager GetInstance()
        {
            if (_theUniqueInstance == null)
                return _theUniqueInstance = new ConnectionManager();
            else
                return _theUniqueInstance;
        }

        public static ConnectionManager GetInstance(string pLogin, string pPassword, string pServer, string pDatabase, string pTimeout, bool integrated)
        {
            if (_theUniqueInstance == null)
                return _theUniqueInstance = new ConnectionManager(pLogin, pPassword, pServer, pDatabase, pTimeout, integrated);
            else
                return _theUniqueInstance;
        }

        public static void KillSingleton()
        {            
            _theUniqueInstance = null;
        }

        public SqlConnection GetSqlConnection()
        {
            return _connectionManager.GetSqlConnection();
        }
      
        public SqlConnection SqlConnection
        {
            get { return _connectionManager.SqlConnection; }
        }


        public SqlTransaction GetSqlTransaction()
        {
            return _connectionManager.GetSqlTransaction();
        }

        public void CloseConnection()
        {
            _connectionManager.CloseConnection();
        }
        
        public bool ConnectionInitSuceeded
        {
            get { return _connectionManager.ConnectionInitSuceeded; }
        }

        public SqlConnection SqlConnectionOnMaster
        {
            get { return _connectionManager.SqlConnectionOnMaster; }
        }

        public SqlConnection SqlConnectionForRestore
        {
            get { return _connectionManager.SqlConnectionForRestore; }
        }

        public void KillAllConnections()
        {
            _connectionManager.KillAllConnections();
        }

        public static bool CheckSQLServerConnection()
        {
            return Standard.CheckSQLServerConnection();
        }

        public static bool CheckSQLDatabaseConnection()
        {
            return Standard.CheckSQLDatabaseConnection();
        }
        public static SqlConnection GeneralSqlConnection
        {
            get
            {
                return Standard.MasterConnection();
            }
        }
        
    }
}
