using ListFile1.Models;
using ListFile1.Services;
using System.Data;

namespace ListFile1.PresentationWF
{
    public partial class Form1 : Form
    {
        #region Private Fields

        private FileSaver _fileSaver;
        private ListIncrement _listIncrementService;

        #endregion

        #region Constructor

        public Form1()
        {
            _fileSaver = new();
            _listIncrementService = new();

            InitializeComponent();
        }

        #endregion

        #region Forms Events

        private async void SaveFile_Click(object sender, EventArgs e)
        {
            var prizeList = new List<Prize>();

            foreach (var row in dgwTable12.Rows
                    .OfType<DataGridViewRow>()
                    .SkipLast(1).ToList())
            {
                string name = row.Cells["PrizeName"].Value.ToString();
                int count = int.Parse(row.Cells["Amount"].Value.ToString());
                if (name != "" && count > 0)
                {
                    _listIncrementService.AddToList(prizeList, name, count);
                }
            }

            if (prizeList.Count == 0)
            {
                MessageBox.Show("Список пуст!");
                return;
            }

            if (rbtRandomize.Checked)
            {
                var randomizeListService = new RandomizeList<Prize>();
                prizeList = randomizeListService.GetList(prizeList);
            }

            if (rbtProportion.Checked)
            {
                var inputParams = dgwTable12.Rows
                    .OfType<DataGridViewRow>()
                    .SkipLast(1)
                    .Select(w => new InputPrize(w.Cells["PrizeName"].Value.ToString(), int.Parse(w.Cells["Amount"].Value.ToString()))).ToList();

                prizeList = Proporcion.GetListOredrly(inputParams);
            }

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

            try
            {
                if (rbtLength.Checked)
                {
                    codeGenerator = new(range, length, amount);
                }
                else if (rbtTemplate.Checked)
                {
                    codeGenerator = new(range, template, amount);
                }
                else
                {
                    return;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Максимально возможное количество комбинаций: {ex.ActualValue}");
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

            foreach (var row in dgwTable4.Rows
                    .OfType<DataGridViewRow>()
                    .SkipLast(1).ToList())
            {
                string city = row.Cells["BlockName"].Value.ToString();

                if (city == "")
                    break;

                var matrixItem = new Matrix() { City = city };

                matrixItem.PrizeList = new();

                for (int i = 1; i < row.Cells.Count; i++)
                {
                    string prizeName = row.Cells[i].Value.ToString();
                    i++;
                    int prizeCount = int.Parse(row.Cells[i].Value.ToString());

                    _listIncrementService.AddToList(matrixItem.PrizeList, prizeName, prizeCount);
                }

                matrix.Add(matrixItem);

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

            CreateTable4(columnsCount);
        }

        private void IntOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTemplate_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string validCharsForTemplate = " -!@";

            if (!char.IsControl(e.KeyChar) && !validCharsForTemplate.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgw_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            PCreateAdv.Visible = e.TabPageIndex == 2;
            btnSaveTable.Visible = e.TabPageIndex == 2;
            btnSaveCodes.Visible = e.TabPageIndex == 1;
            btnSaveFile.Visible = e.TabPageIndex == 0;
        }

        private void dgwTable12_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // 1 is column index for amount ;
            if (e.ColumnIndex != 1)
                return;

            IntColumnsValidation(e);
        }

        private void dgwTable4_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex % 2 == 1)
                return;

            IntColumnsValidation(e);
        }

        private void dgwTable12_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgwTable12.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgwTable4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgwTable12.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        #endregion

        #region Private Methods

        private void FillTable12TestData()
        {
            dgwTable12.Columns.Clear();
            dgwTable12.Columns.Add("PrizeName","Приз");
            dgwTable12.Columns.Add("Amount", "Количество");

            dgwTable12.Rows.Add("Чашка", 5);
            dgwTable12.Rows.Add("Стакан", 2);
            dgwTable12.Rows.Add("Ложка", 10);
            dgwTable12.Rows.Add("Салфетка", 50);

        }

        private void FillTable4TestData()
        {
            CreateTable4(5);

            dgwTable4.Rows.Add("Киев", "5%", 100, "7%", 50, "10%", 30, "15%", 10, "25%", 3);
            dgwTable4.Rows.Add("Одесса", "5%", 90, "7%", 30, "10%", 25, "15%", 6, "25%", 2);
            dgwTable4.Rows.Add("Севастополь", "5%", 80, "7%", 60, "10%", 16, "15%", 7, "25%", 4);
            dgwTable4.Rows.Add("Харьков", "5%", 95, "7%", 50, "10%", 23, "15%", 9, "25%", 2);
            dgwTable4.Rows.Add("Львов", "5%", 70, "7%", 30, "10%", 29, "15%", 12, "25%", 1);
        }

        private void CreateTable4(int columnsCount)
        {
            dgwTable4.DataSource = null;
            dgwTable4.Rows.Clear();
            dgwTable4.Columns.Clear();
            dgwTable4.Columns.Add("BlockName", "Наименование блока");

            for (int i = 1; i <= columnsCount; i++)
            {
                dgwTable4.Columns.Add($"PrizeName{i}", $"Приз {i}");
                dgwTable4.Columns.Add($"Amount{i}", $"Количество Приз {i}");
            }
        }

        private void IntColumnsValidation(DataGridViewCellValidatingEventArgs e)
        {
            var enteredString = e.FormattedValue.ToString();
            var isInvalidValidString = string.IsNullOrWhiteSpace(enteredString);
            if (isInvalidValidString)
            {
                dgwTable12.Rows[e.RowIndex].ErrorText = "Количество не може бути пустим ";
                e.Cancel = true;
                return;
            }
            isInvalidValidString = enteredString.Trim().Any(x => !char.IsNumber(x));
            if (isInvalidValidString)
            {
                dgwTable12.Rows[e.RowIndex].ErrorText = "Количество може бути тільки цілим числом ";
                e.Cancel = true;
                return;
            }
        }
        #endregion
    }
}