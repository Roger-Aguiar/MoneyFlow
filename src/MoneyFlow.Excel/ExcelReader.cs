#nullable disable
namespace MoneyFlow.src.MoneyFlow.Excel
{
    public class ExcelReader
    {
        private const int START_ROW = 6;

        public List<FinancialRecord> Read(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path is invalid,");

            var records = new List<FinancialRecord>();
            using var workbook = new XLWorkbook(filePath);

            var worksheet = workbook.Worksheets.First();
            var currentRow = START_ROW;

            while(!worksheet.Cell(currentRow, 1).IsEmpty())
            {
                try
                {
                    //Mapear colunas
                    var transactionDate = worksheet.Cell(currentRow, 1).GetDateTime();
                    var history = worksheet.Cell(currentRow, 2).GetString();
                    var description = worksheet.Cell(currentRow, 3).GetString();
                    var amount = worksheet.Cell(currentRow, 4).GetValue<decimal>();

                    //Criar entidade do Domain
                    var record = new FinancialRecord(
                        transactionDate,
                        history,
                        description,
                        amount
                        );

                    records.Add(record);
                }
                catch
                {

                }

                currentRow++;
            }
            return records;
        }
    }
}
