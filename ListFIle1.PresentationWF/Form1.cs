using ListFile1.Models;
using ListFile1.Services;
using System.Data;
//using ListFile1.PresentationWF.Extensions;

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

            SetIntTextBoxes();

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
                string name = row.Cells[0].Value.ToString();
                int count = int.Parse(row.Cells[1].Value.ToString());
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
                    .Select(w => new InputPrize(w.Cells[0].Value.ToString(), int.Parse(w.Cells[1].Value.ToString()))).ToList();

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

            foreach (var row in dgwTable12.Rows
                    .OfType<DataGridViewRow>()
                    .SkipLast(1).ToList())
            {
                string city = row.Cells[0].Value.ToString();

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

            dgwTable4.DataSource = null;

            var clearTable = new DataTable();

            CreateTable4(clearTable, columnsCount);
            dgwTable4.DataSource = clearTable;
        }

        private void IntOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void SetIntTextBoxes()
        {
            //tbxLength.SetIntValidation();
            //tbxLength.KeyPress += new KeyPressEventHandler(IntOnly_KeyPress);
        }

        #endregion


    }
}