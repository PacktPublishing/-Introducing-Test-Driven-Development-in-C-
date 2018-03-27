using System;
using System.Data;
using System.Data.SqlClient;

namespace SRP
{
    public class CommandFactory : ICommandFactory
    {
        public IDbCommand RetriveSelectEntityCommand(SqlConnection sqlConnection)
        {
            return new SqlCommand("select * from Entity", sqlConnection);
        }

        public IDbCommand RetriveUpdateEntityCommand(SqlConnection sqlConnection, Entity entity, int newValue)
        {
            return new SqlCommand(
                $"update Entity set Data = {newValue} where Data = {entity.Value}", sqlConnection);
        }
    }
}
