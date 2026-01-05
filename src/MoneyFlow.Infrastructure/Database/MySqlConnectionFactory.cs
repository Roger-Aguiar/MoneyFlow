#nullable disable
namespace MoneyFlow.src.MoneyFlow.Infrastructure.Database
{
    public class MySqlConnectionFactory(string connectionString)
    {
        private readonly string _connectionString = connectionString;

        public MySqlConnection Create() => new(_connectionString);
    }
}
