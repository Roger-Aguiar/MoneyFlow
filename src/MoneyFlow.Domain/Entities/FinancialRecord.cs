#nullable disable

namespace MoneyFlow.src.MoneyFlow.Domain.Entities
{
    public class FinancialRecord
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string History { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
