using System;
using System.Data.SqlClient;

namespace SRP
{
    public class SqlConnectionHandler : ISqlConnectionWrapper
    {
        public SqlConnection SqlConnection { get; private set; }

        public SqlConnectionHandler(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("connectionString");
            }

            SqlConnection = new SqlConnection(connectionString);
        }
    }
}
