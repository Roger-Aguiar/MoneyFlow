#nullable disable

namespace MoneyFlow.src.MoneyFlow.Infrastructure.Repositories
{
    public class FinancialRecordRepository(MySqlConnectionFactory connectionFactory)
    {
        private readonly MySqlConnectionFactory _connectionFactory = connectionFactory;

        public void Add(FinancialRecord record)
        {
            using var connection = _connectionFactory.Create();
            connection.Open();

            var sql = @"
                INSERT INTO financial_records
                (transaction_date, history, description, amount, transaction_type)
                VALUES
                (@date, @history, @description, @amount, @type);
            ";

            using var command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@date", record.TransactionDate);
            command.Parameters.AddWithValue("@history", record.History);
            command.Parameters.AddWithValue("@description", record.Description);
            command.Parameters.AddWithValue("@amount", record.Amount);
            command.Parameters.AddWithValue("@type", (int)record.TransactionType);

            command.ExecuteNonQuery();
        }

        public IEnumerable<FinancialRecord> GetByPeriod(DateTime startDate, DateTime endDate)
        {
            var records = new List<FinancialRecord>();

            using var connection = _connectionFactory.Create();
            connection.Open();

            var sql = @"
                SELECT 
                    transaction_date,
                    history,
                    description,
                    amount,
                    transaction_type
                FROM financial_records
                WHERE transaction_date BETWEEN @start AND @end;
            ";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@start", startDate);
            command.Parameters.AddWithValue("@end", endDate);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var record = new FinancialRecord(
                    reader.GetDateTime("transaction_date"),
                    reader.GetString("history"),
                    reader.GetString("description"),
                    reader.GetDecimal("amount")
                );

                records.Add(record);
            }

            return records;
        }
    }
}
