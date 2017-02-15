using System;
using System.Data.SqlClient;

namespace LQT.GUI
{
    public interface IConnectionManager
    {
        void CloseConnection();
        bool ConnectionInitSuceeded { get; }
        void KillAllConnections();
        
        SqlConnection GetSqlConnection();
        SqlTransaction GetSqlTransaction();

        SqlConnection SqlConnection { get; }
        SqlConnection SqlConnectionForRestore { get; }
        SqlConnection SqlConnectionOnMaster { get; }
    }
}
