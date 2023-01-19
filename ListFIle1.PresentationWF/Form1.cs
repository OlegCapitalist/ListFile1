using ListFile1.Models;
using ListFile1.Services;
using System.Data;

namespace ListFile1.PresentationWF
{
    public partial class Form1 : Form
    {
        #region Private Fields

        private FileSaver _fileSaver;

        #endregion

        #region Constructor

        public Form1()
        {
            _fileSaver = new();
            InitializeComponent();
        }

        #endregion

        #region Forms Events

        private async void SaveFile_Click(object sender, EventArgs e)
        {
            var prizeList = new List<Prize>();

            foreach(var row in dgwTable12.Rows)
            {
                if (row is DataGridViewRow currentRow)
                {
                    string name = (string)currentRow.Cells[0].FormattedValue;
                    string countStr = (string)currentRow.Cells[1].FormattedValue;

                    int count = countStr == "" ? 0 : Convert.ToInt32(countStr);

                    if (name != "" && count > 0)
                    {
                        ListIncrement.GetList(prizeList, name, count);
                    }
                }
            }

            if (prizeList.Count == 0)
            {
                MessageBox.Show("Список пуст!");
                return;
            }

            if (rbtRandomize.Checked)
                prizeList = RandomizeList<Prize>.GetList(prizeList);

            if (rbtProportion.Checked)
                prizeList = Proporcion.GetList(prizeList);

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            await _fileSaver.SaveNumeratedListAsync(saveFileDialog.FileName, prizeList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTable12TestData();
            FillTable4TestData();
        }

        private async void btnSaveCodes_Click(object sender, EventArgs e)
        {
            CodeGenerator codeGenerator;

            string range = tbxRange.Text;
            string template = tbxTemplate.Text;

            int amount = Convert.ToInt32(tbxAmount.Text);
            int length = Convert.ToInt32(tbxLength.Text);

            if (rbtLength.Checked)
            {
                codeGenerator = new (range, length, amount);
            }
            else if (rbtTemplate.Checked)
            {
                codeGenerator = new(range, template, amount);
            }
            else
            {
                return;
            }

            var codes = codeGenerator.GetList();

            if (codes.Count == 0)
            {
                MessageBox.Show("Список пуст!");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            await _fileSaver.SaveListAsync(saveFileDialog.FileName, codes);
        }

        private async void btnSaveTable_Click(object sender, EventArgs e)
        {
            var matrix = new List<Matrix>();

            foreach (var row in dgwTable4.Rows)
            {
                if (row is DataGridViewRow currentRow)
                {
                    string city = (string)currentRow.Cells[0].FormattedValue;

                    if (city == "")
                        break;

                    var matrixItem = new Matrix() { City = city };

                    matrixItem.PrizeList = new();

                    for (int i = 1; i < currentRow.Cells.Count; i++)
                    {
                        string prizeName = (string)currentRow.Cells[i].FormattedValue;
                        i++;
                        string prizeCount = (string)currentRow.Cells[i].FormattedValue;

                        ListIncrement.GetList(matrixItem.PrizeList, prizeName, Convert.ToInt32(prizeCount));
                    }

                    matrix.Add(matrixItem);
                }
            }

            if (matrix.Count == 0)
            {
                MessageBox.Show("Список пуст!");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            await _fileSaver.SaveMatrixAsync(saveFileDialog.FileName, matrix);
        }

        private void btnCreateColumns_Click(object sender, EventArgs e)
        {
            int columnsCount = Convert.ToInt32(tbxColumnsCount.Text);

            dgwTable4.Rows.Clear();
            dgwTable4.Columns.Clear();

            CreateTable4(new DataTable(), columnsCount);
        }

        #endregion

        #region Private Methods

        private void FillTable12TestData()
        {
            var testTable = new DataTable();
            testTable.Columns.Add(new DataColumn("Prize", typeof(string)) { ColumnName = "Приз" });
            testTable.Columns.Add(new DataColumn("Amount", typeof(int)) { ColumnName = "Количество", DefaultValue = 0 });

            testTable.Rows.Add("Чашка", 5);
            testTable.Rows.Add("Стакан", 2);
            testTable.Rows.Add("Ложка", 10);
            testTable.Rows.Add("Салфетка", 50);

            dgwTable12.DataSource = testTable;
        }

        private void FillTable4TestData()
        {
            var testTable = new DataTable();

            CreateTable4(testTable, 5);

            testTable.Rows.Add("Киев",          "5%", 100,  "7%", 50, "10%", 30, "15%", 10, "25%", 3);
            testTable.Rows.Add("Одесса",        "5%", 90,   "7%", 30, "10%", 25, "15%", 6,  "25%", 2);
            testTable.Rows.Add("Севастополь",   "5%", 80,   "7%", 60, "10%", 16, "15%", 7,  "25%", 4);
            testTable.Rows.Add("Харьков",       "5%", 95,   "7%", 50, "10%", 23, "15%", 9,  "25%", 2);
            testTable.Rows.Add("Львов",         "5%", 70,   "7%", 30, "10%", 29, "15%", 12, "25%", 1);

            dgwTable4.DataSource = testTable;
        }

        private void CreateTable4(DataTable testTable, int columnsCount)
        {
            testTable.Columns.Add(new DataColumn("BlockName", typeof(string)) { ColumnName = "Наименование блока" });

            for (int i = 1; i <= columnsCount; i++)
            {
                testTable.Columns.Add(new DataColumn($"PrizeName{i}", typeof(string)) { ColumnName = $"Приз {i}" }) ;
                testTable.Columns.Add(new DataColumn($"Amount{i}", typeof(int)) { ColumnName = $"Количество Приз {i}", DefaultValue = 0 });
            }
        }

        #endregion
    }
}