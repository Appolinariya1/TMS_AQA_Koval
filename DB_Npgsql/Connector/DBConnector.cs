using DB_Npgsql.Helpers.Configuration;
using Npgsql;

namespace DB_Npgsql.Connector;

public class DBConnector
{
    public NpgsqlConnection Connection { get; init; }
    public DBConnector()
    {
        var connectionString = $"Host={Configurator.DbSettings.Server};" +
                               $"Port={Configurator.DbSettings.Port};" +
                               $"Database={Configurator.DbSettings.Name};" +
                               $"User Id={Configurator.DbSettings.Username};" +
                               $"Password={Configurator.DbSettings.Password};";
        Connection = new NpgsqlConnection(connectionString);
        Connection.Open();
    }

    public void CloseConnection()
    {
        Connection.Close();
    }
}