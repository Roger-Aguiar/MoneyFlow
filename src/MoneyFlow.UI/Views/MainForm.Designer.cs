namespace MoneyFlow
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonImportExcelSheet = new Button();
            panel1 = new Panel();
            ButtonFilter = new Button();
            label2 = new Label();
            DateTimePickerEnd = new DateTimePicker();
            label1 = new Label();
            DateTimePickerInitial = new DateTimePicker();
            DataGridViewFinancialRecords = new DataGridView();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnHistory = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFinancialRecords).BeginInit();
            SuspendLayout();
            // 
            // ButtonImportExcelSheet
            // 
            ButtonImportExcelSheet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ButtonImportExcelSheet.Location = new Point(20, 20);
            ButtonImportExcelSheet.Name = "ButtonImportExcelSheet";
            ButtonImportExcelSheet.Size = new Size(220, 45);
            ButtonImportExcelSheet.TabIndex = 0;
            ButtonImportExcelSheet.Text = "Importar Planilha Excel";
            ButtonImportExcelSheet.UseVisualStyleBackColor = true;
            ButtonImportExcelSheet.Click += ButtonImportExcelSheet_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ButtonFilter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DateTimePickerEnd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DateTimePickerInitial);
            panel1.Controls.Add(ButtonImportExcelSheet);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 88);
            panel1.TabIndex = 1;
            // 
            // ButtonFilter
            // 
            ButtonFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ButtonFilter.Location = new Point(893, 20);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(150, 45);
            ButtonFilter.TabIndex = 6;
            ButtonFilter.Text = "Filtrar";
            ButtonFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(579, 32);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 5;
            label2.Text = "Data final: ";
            // 
            // DateTimePickerEnd
            // 
            DateTimePickerEnd.Font = new Font("Segoe UI", 12F);
            DateTimePickerEnd.Format = DateTimePickerFormat.Short;
            DateTimePickerEnd.Location = new Point(678, 26);
            DateTimePickerEnd.Name = "DateTimePickerEnd";
            DateTimePickerEnd.Size = new Size(200, 29);
            DateTimePickerEnd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(274, 32);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 3;
            label1.Text = "Data inicial: ";
            // 
            // DateTimePickerInitial
            // 
            DateTimePickerInitial.Font = new Font("Segoe UI", 12F);
            DateTimePickerInitial.Format = DateTimePickerFormat.Short;
            DateTimePickerInitial.Location = new Point(373, 26);
            DateTimePickerInitial.Name = "DateTimePickerInitial";
            DateTimePickerInitial.Size = new Size(200, 29);
            DateTimePickerInitial.TabIndex = 2;
            // 
            // DataGridViewFinancialRecords
            // 
            DataGridViewFinancialRecords.AllowUserToAddRows = false;
            DataGridViewFinancialRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewFinancialRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFinancialRecords.Columns.AddRange(new DataGridViewColumn[] { ColumnDate, ColumnHistory, ColumnDescription, ColumnAmount, ColumnType });
            DataGridViewFinancialRecords.Location = new Point(12, 118);
            DataGridViewFinancialRecords.Name = "DataGridViewFinancialRecords";
            DataGridViewFinancialRecords.ReadOnly = true;
            DataGridViewFinancialRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewFinancialRecords.Size = new Size(1060, 531);
            DataGridViewFinancialRecords.TabIndex = 2;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Data";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnHistory
            // 
            ColumnHistory.HeaderText = "Histórico";
            ColumnHistory.Name = "ColumnHistory";
            ColumnHistory.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            ColumnDescription.HeaderText = "Descrição";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            ColumnAmount.HeaderText = "Valor";
            ColumnAmount.Name = "ColumnAmount";
            ColumnAmount.ReadOnly = true;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Tipo";
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(DataGridViewFinancialRecords);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Money Flow";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFinancialRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonImportExcelSheet;
        private Panel panel1;
        private Label label1;
        private DateTimePicker DateTimePickerInitial;
        private Button ButtonFilter;
        private Label label2;
        private DateTimePicker DateTimePickerEnd;
        private DataGridView DataGridViewFinancialRecords;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnHistory;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnType;
    }
}
