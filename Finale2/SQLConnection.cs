
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale
{
    public class SQLConnection
    {
        private const string DEFAULT_USER_ID = "GreatestGroup";
        private const string DEFAULT_PASSWORD = "password";
        private const string DEFAULT_SERVER = "champlainmssql.cabect4hsdzs.us-east-1.rds.amazonaws.com,7788";
        private const string DEFAULT_DATABASE_NAME = "Champlain Music Store";
        private const string DEFAULT_TIMEOUT = "connection timeout=30";

        private string mUserId { get; set; }
        private string mPassword { get; set; }
        private string mServer { get; set; }
        private string mDatabaseName { get; set;}

		/**
		 * Default constructor for the SQL connection
		 */
        public SQLConnection()
        {
            mUserId = DEFAULT_USER_ID;
            mPassword = DEFAULT_PASSWORD;
            mServer = DEFAULT_SERVER;
            mDatabaseName = DEFAULT_DATABASE_NAME;
        }

		/**
		 * Constructor for the SQL connection
		 *
		 * @param string userId
		 * @param string password
		 * @param string server
		 * @param databaseName
		 */
        public SQLConnection(string userId, string password, string server, string databaseName)
        {
            mUserId = userId;
            mPassword = password;
            mServer = server;
            mDatabaseName = databaseName;
        }

		/**
		 * Execute a query on the SQL connection
		 *
		 * @param string tableName
		 * @param string queryStatement
		 * @return DataTable
		 */
        public System.Data.DataTable execute(string tableName, string queryStatement)
        {
            System.Data.DataTable table;

            using (System.Data.SqlClient.SqlConnection _con = new System.Data.SqlClient.SqlConnection(
                  "user id=" + mUserId + ";"
                + "password=" + mPassword + ";"
                + "server=" + mServer + ";"
                + "database=" + mDatabaseName + ";"
                + DEFAULT_TIMEOUT))
            {
                using (System.Data.SqlClient.SqlCommand _cmd = new System.Data.SqlClient.SqlCommand(queryStatement, _con))
                {
                    table = new System.Data.DataTable(tableName);

                    System.Data.SqlClient.SqlDataAdapter _dap = new System.Data.SqlClient.SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(table);
                    _con.Close();
                }
            }

            return table;
        }
    }
}
