#nullable disable
using MoneyFlow.src.MoneyFlow.Excel;
using MoneyFlow.src.MoneyFlow.Infrastructure.Repositories;
using System.Globalization;

namespace MoneyFlow
{
    public partial class MainForm : Form
    {
        private const string CONNECTION_STRING = "Server=localhost;Database=moneyflow;User Id=root;Password=983453069;";

        public MainForm()
        {
            InitializeComponent();
        }

        

        #region Private methods

        private void ImportExcelSheet()
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Selecione a planilha de extrato",
                Filter = "Arquivos Excel (*.xlsx)|*.xlsx",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var excelReader = new ExcelReader();
                var records = excelReader.Read(openFileDialog.FileName);

                var factory = new MySqlConnectionFactory(CONNECTION_STRING);

                var repository = new FinancialRecordRepository(factory);

                foreach (var record in records)
                {
                    repository.Add(record);
                }

                MessageBox.Show("Importação realizada com sucesso!", "MoneyFlow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFinancialRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao importar arquivo:\n{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadFinancialRecords()
        {
            var culture = new CultureInfo("pt-BR");

            DataGridViewFinancialRecords.Rows.Clear();

            var factory = new MySqlConnectionFactory(CONNECTION_STRING);

            var repository = new FinancialRecordRepository(factory);

            var records = repository.GetByPeriod(
                DateTime.MinValue,
                DateTime.MaxValue
            );

            foreach (var record in records)
            {
                DataGridViewFinancialRecords.Rows.Add(
                    record.TransactionDate.ToString("dd/MM/yyyy"),
                    record.History,
                    record.Description,
                    record.Amount.ToString("C", culture),
                    record.TransactionType == TransactionType.INCOME ? "Entrada" : "Saída"
                );
            }
        }

        #endregion

        private void ButtonImportExcelSheet_Click(object sender, EventArgs e)
        {
            ImportExcelSheet();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFinancialRecords();
        }
    }
}
