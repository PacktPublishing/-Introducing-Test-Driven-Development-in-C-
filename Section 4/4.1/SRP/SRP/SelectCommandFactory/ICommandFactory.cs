using System.Data;
using System.Data.SqlClient;

namespace SRP
{
    public interface ICommandFactory
    {
        IDbCommand RetriveSelectEntityCommand(SqlConnection sqlConnection);
        IDbCommand RetriveUpdateEntityCommand(SqlConnection sqlConnection, Entity entity, int newValue);
    }
}
