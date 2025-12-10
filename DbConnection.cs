using System.Data.SqlClient;

public class DbConnection
{
    private readonly string connectionString =
        "Server=localhost;Database=DistributorDB;Trusted_Connection=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
