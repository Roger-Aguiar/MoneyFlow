using MoneyFlow.src.MoneyFlow.Excel;
using MoneyFlow.src.MoneyFlow.Infrastructure.Repositories;

namespace MoneyFlow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestExcel();

        }

        private static void TestExcel()
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

                var factory = new MySqlConnectionFactory("Server=localhost;Database=moneyflow;User Id=root;Password=983453069;"
                );

                var repository = new FinancialRecordRepository(factory);

                foreach (var record in records)
                {
                    repository.Add(record);
                }

                MessageBox.Show("Importação realizada com sucesso!", "MoneyFlow", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
