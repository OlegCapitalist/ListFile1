
namespace ListFile1.PresentationWF
{
    partial class Form1
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOption12 = new System.Windows.Forms.TabPage();
            this.rbtRandomize = new System.Windows.Forms.RadioButton();
            this.rbtProportion = new System.Windows.Forms.RadioButton();
            this.rbtStraigth = new System.Windows.Forms.RadioButton();
            this.SaveFile = new System.Windows.Forms.Button();
            this.dgwTable12 = new System.Windows.Forms.DataGridView();
            this.tabPageOption3 = new System.Windows.Forms.TabPage();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.rbtTemplate = new System.Windows.Forms.RadioButton();
            this.rbtLength = new System.Windows.Forms.RadioButton();
            this.btnSaveCodes = new System.Windows.Forms.Button();
            this.tbxTemplate = new System.Windows.Forms.TextBox();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.tbxRange = new System.Windows.Forms.TextBox();
            this.tabPageOption4 = new System.Windows.Forms.TabPage();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.lblColumnsCount = new System.Windows.Forms.Label();
            this.tbxColumnsCount = new System.Windows.Forms.TextBox();
            this.dgwTable4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageOption12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable12)).BeginInit();
            this.tabPageOption3.SuspendLayout();
            this.tabPageOption4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable4)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "output.csv";
            this.saveFileDialog.Filter = "CSV tables|*.csv|Text files|*.txt|All files|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOption12);
            this.tabControl1.Controls.Add(this.tabPageOption3);
            this.tabControl1.Controls.Add(this.tabPageOption4);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 434);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageOption12
            // 
            this.tabPageOption12.Controls.Add(this.rbtRandomize);
            this.tabPageOption12.Controls.Add(this.rbtProportion);
            this.tabPageOption12.Controls.Add(this.rbtStraigth);
            this.tabPageOption12.Controls.Add(this.SaveFile);
            this.tabPageOption12.Controls.Add(this.dgwTable12);
            this.tabPageOption12.Location = new System.Drawing.Point(4, 24);
            this.tabPageOption12.Name = "tabPageOption12";
            this.tabPageOption12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOption12.Size = new System.Drawing.Size(768, 406);
            this.tabPageOption12.TabIndex = 0;
            this.tabPageOption12.Text = "Варианты 1, 2";
            this.tabPageOption12.UseVisualStyleBackColor = true;
            // 
            // rbtRandomize
            // 
            this.rbtRandomize.AutoSize = true;
            this.rbtRandomize.Location = new System.Drawing.Point(599, 108);
            this.rbtRandomize.Name = "rbtRandomize";
            this.rbtRandomize.Size = new System.Drawing.Size(95, 19);
            this.rbtRandomize.TabIndex = 5;
            this.rbtRandomize.Text = "Смешанный";
            this.rbtRandomize.UseVisualStyleBackColor = true;
            // 
            // rbtProportion
            // 
            this.rbtProportion.AutoSize = true;
            this.rbtProportion.Location = new System.Drawing.Point(599, 83);
            this.rbtProportion.Name = "rbtProportion";
            this.rbtProportion.Size = new System.Drawing.Size(139, 19);
            this.rbtProportion.TabIndex = 4;
            this.rbtProportion.Text = "Пропорциональный";
            this.rbtProportion.UseVisualStyleBackColor = true;
            // 
            // rbtStraigth
            // 
            this.rbtStraigth.AutoSize = true;
            this.rbtStraigth.Checked = true;
            this.rbtStraigth.Location = new System.Drawing.Point(599, 58);
            this.rbtStraigth.Name = "rbtStraigth";
            this.rbtStraigth.Size = new System.Drawing.Size(70, 19);
            this.rbtStraigth.TabIndex = 3;
            this.rbtStraigth.TabStop = true;
            this.rbtStraigth.Text = "Прямой";
            this.rbtStraigth.UseVisualStyleBackColor = true;
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(687, 377);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 23);
            this.SaveFile.TabIndex = 2;
            this.SaveFile.Text = "Сохранить";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // dgwTable12
            // 
            this.dgwTable12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable12.Location = new System.Drawing.Point(-4, 0);
            this.dgwTable12.Name = "dgwTable12";
            this.dgwTable12.RowTemplate.Height = 25;
            this.dgwTable12.Size = new System.Drawing.Size(581, 410);
            this.dgwTable12.TabIndex = 1;
            // 
            // tabPageOption3
            // 
            this.tabPageOption3.Controls.Add(this.lblAmount);
            this.tabPageOption3.Controls.Add(this.tbxAmount);
            this.tabPageOption3.Controls.Add(this.rbtTemplate);
            this.tabPageOption3.Controls.Add(this.rbtLength);
            this.tabPageOption3.Controls.Add(this.btnSaveCodes);
            this.tabPageOption3.Controls.Add(this.tbxTemplate);
            this.tabPageOption3.Controls.Add(this.tbxLength);
            this.tabPageOption3.Controls.Add(this.lblRange);
            this.tabPageOption3.Controls.Add(this.tbxRange);
            this.tabPageOption3.Location = new System.Drawing.Point(4, 24);
            this.tabPageOption3.Name = "tabPageOption3";
            this.tabPageOption3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOption3.Size = new System.Drawing.Size(768, 406);
            this.tabPageOption3.TabIndex = 1;
            this.tabPageOption3.Text = "Вариант 3";
            this.tabPageOption3.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 128);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 15);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Количество кодов:";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(125, 125);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(100, 23);
            this.tbxAmount.TabIndex = 9;
            this.tbxAmount.Text = "1000";
            // 
            // rbtTemplate
            // 
            this.rbtTemplate.AutoSize = true;
            this.rbtTemplate.Checked = true;
            this.rbtTemplate.Location = new System.Drawing.Point(38, 92);
            this.rbtTemplate.Name = "rbtTemplate";
            this.rbtTemplate.Size = new System.Drawing.Size(73, 19);
            this.rbtTemplate.TabIndex = 8;
            this.rbtTemplate.TabStop = true;
            this.rbtTemplate.Text = "Шаблон:";
            this.rbtTemplate.UseVisualStyleBackColor = true;
            // 
            // rbtLength
            // 
            this.rbtLength.AutoSize = true;
            this.rbtLength.Location = new System.Drawing.Point(38, 56);
            this.rbtLength.Name = "rbtLength";
            this.rbtLength.Size = new System.Drawing.Size(63, 19);
            this.rbtLength.TabIndex = 7;
            this.rbtLength.Text = "Длина:";
            this.rbtLength.UseVisualStyleBackColor = true;
            // 
            // btnSaveCodes
            // 
            this.btnSaveCodes.Location = new System.Drawing.Point(687, 377);
            this.btnSaveCodes.Name = "btnSaveCodes";
            this.btnSaveCodes.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCodes.TabIndex = 6;
            this.btnSaveCodes.Text = "Сохранить";
            this.btnSaveCodes.UseVisualStyleBackColor = true;
            this.btnSaveCodes.Click += new System.EventHandler(this.btnSaveCodes_Click);
            // 
            // tbxTemplate
            // 
            this.tbxTemplate.Location = new System.Drawing.Point(125, 91);
            this.tbxTemplate.Name = "tbxTemplate";
            this.tbxTemplate.Size = new System.Drawing.Size(71, 23);
            this.tbxTemplate.TabIndex = 4;
            this.tbxTemplate.Text = "!!@!!!";
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(126, 55);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(70, 23);
            this.tbxLength.TabIndex = 2;
            this.tbxLength.Text = "3";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(3, 20);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(121, 15);
            this.lblRange.TabIndex = 1;
            this.lblRange.Text = "Диапазон символов:";
            // 
            // tbxRange
            // 
            this.tbxRange.Location = new System.Drawing.Point(126, 17);
            this.tbxRange.Name = "tbxRange";
            this.tbxRange.Size = new System.Drawing.Size(636, 23);
            this.tbxRange.TabIndex = 0;
            this.tbxRange.Text = "AZVREBNKLYURDWXvgfht1236789";
            // 
            // tabPageOption4
            // 
            this.tabPageOption4.Controls.Add(this.btnSaveTable);
            this.tabPageOption4.Controls.Add(this.lblColumnsCount);
            this.tabPageOption4.Controls.Add(this.tbxColumnsCount);
            this.tabPageOption4.Controls.Add(this.dgwTable4);
            this.tabPageOption4.Location = new System.Drawing.Point(4, 24);
            this.tabPageOption4.Name = "tabPageOption4";
            this.tabPageOption4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOption4.Size = new System.Drawing.Size(768, 406);
            this.tabPageOption4.TabIndex = 2;
            this.tabPageOption4.Text = "Вариант 4";
            this.tabPageOption4.UseVisualStyleBackColor = true;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Location = new System.Drawing.Point(687, 373);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTable.TabIndex = 3;
            this.btnSaveTable.Text = "Сохранить";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // lblColumnsCount
            // 
            this.lblColumnsCount.AutoSize = true;
            this.lblColumnsCount.Location = new System.Drawing.Point(6, 377);
            this.lblColumnsCount.Name = "lblColumnsCount";
            this.lblColumnsCount.Size = new System.Drawing.Size(122, 15);
            this.lblColumnsCount.TabIndex = 2;
            this.lblColumnsCount.Text = "Количество колонок";
            // 
            // tbxColumnsCount
            // 
            this.tbxColumnsCount.Location = new System.Drawing.Point(134, 374);
            this.tbxColumnsCount.Name = "tbxColumnsCount";
            this.tbxColumnsCount.Size = new System.Drawing.Size(100, 23);
            this.tbxColumnsCount.TabIndex = 1;
            this.tbxColumnsCount.Text = "5";
            // 
            // dgwTable4
            // 
            this.dgwTable4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable4.Location = new System.Drawing.Point(0, 3);
            this.dgwTable4.Name = "dgwTable4";
            this.dgwTable4.RowTemplate.Height = 25;
            this.dgwTable4.Size = new System.Drawing.Size(768, 353);
            this.dgwTable4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOption12.ResumeLayout(false);
            this.tabPageOption12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable12)).EndInit();
            this.tabPageOption3.ResumeLayout(false);
            this.tabPageOption3.PerformLayout();
            this.tabPageOption4.ResumeLayout(false);
            this.tabPageOption4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SaveFileDialog saveFileDialog;
        private TabControl tabControl1;
        private TabPage tabPageOption12;
        private Button SaveFile;
        private DataGridView dgwTable12;
        private TabPage tabPageOption3;
        private TextBox tbxLength;
        private Label lblRange;
        private TextBox tbxRange;
        private TextBox tbxTemplate;
        private RadioButton rbtRandomize;
        private RadioButton rbtProportion;
        private RadioButton rbtStraigth;
        private RadioButton rbtTemplate;
        private RadioButton rbtLength;
        private Button btnSaveCodes;
        private Label lblAmount;
        private TextBox tbxAmount;
        private TabPage tabPageOption4;
        private Button btnSaveTable;
        private Label lblColumnsCount;
        private TextBox tbxColumnsCount;
        private DataGridView dgwTable4;
    }
}