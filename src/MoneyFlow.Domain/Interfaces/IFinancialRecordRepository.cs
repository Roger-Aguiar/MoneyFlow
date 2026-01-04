#nullable disable

namespace MoneyFlow.src.MoneyFlow.Domain.Interfaces
{
    public interface IFinancialRecordRepository
    {
        void Insert(FinancialRecord record);
        IEnumerable<FinancialRecord> GetByPeriod(DateTime start, DateTime end);
    }
}
