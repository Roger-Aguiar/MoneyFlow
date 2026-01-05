#nullable disable

namespace MoneyFlow.Domain.Entities
{
    public class FinancialRecord
    {
        public int Id { get; private set; }

        public DateTime TransactionDate { get; private set; }
        public string History { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public TransactionType TransactionType { get; private set; }

        // Construtor vazio protegido (ORM / serialização no futuro)
        protected FinancialRecord() { }

        // Construtor principal (USADO pelo ExcelReader)
        public FinancialRecord(
            DateTime transactionDate,
            string history,
            string description,
            decimal amount)
        {
            if (transactionDate == default)
                throw new ArgumentException("Transaction date is invalid.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description is required.");

            TransactionDate = transactionDate;
            History = history?.Trim() ?? string.Empty;
            Description = description.Trim();
            Amount = amount;
            TransactionType = amount >= 0
                ? TransactionType.INCOME
                : TransactionType.EXPENSE;
        }
    }
}
