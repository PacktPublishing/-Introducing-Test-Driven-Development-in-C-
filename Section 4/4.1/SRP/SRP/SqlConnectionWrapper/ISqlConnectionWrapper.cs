using System.Data.SqlClient;

namespace SRP
{
    public interface ISqlConnectionWrapper
    {
        SqlConnection SqlConnection { get; }
    }
}
