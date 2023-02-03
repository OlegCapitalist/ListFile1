
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgwTable12 = new System.Windows.Forms.DataGridView();
            this.rbtProportion = new System.Windows.Forms.RadioButton();
            this.rbtRandomize = new System.Windows.Forms.RadioButton();
            this.rbtStraigth = new System.Windows.Forms.RadioButton();
            this.tabPageOption3 = new System.Windows.Forms.TabPage();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.rbtTemplate = new System.Windows.Forms.RadioButton();
            this.rbtLength = new System.Windows.Forms.RadioButton();
            this.tbxTemplate = new System.Windows.Forms.TextBox();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.tbxRange = new System.Windows.Forms.TextBox();
            this.tabPageOption4 = new System.Windows.Forms.TabPage();
            this.dgwTable4 = new System.Windows.Forms.DataGridView();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveCodes = new System.Windows.Forms.Button();
            this.btnCreateColumns = new System.Windows.Forms.Button();
            this.lblColumnsCount = new System.Windows.Forms.Label();
            this.tbxColumnsCount = new System.Windows.Forms.TextBox();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PCreateAdv = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageOption12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable12)).BeginInit();
            this.tabPageOption3.SuspendLayout();
            this.tabPageOption4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.PCreateAdv.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 392);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageOption12
            // 
            this.tabPageOption12.Controls.Add(this.splitContainer1);
            this.tabPageOption12.Location = new System.Drawing.Point(4, 24);
            this.tabPageOption12.Name = "tabPageOption12";
            this.tabPageOption12.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageOption12.Size = new System.Drawing.Size(792, 364);
            this.tabPageOption12.TabIndex = 0;
            this.tabPageOption12.Text = "List base";
            this.tabPageOption12.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgwTable12);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtProportion);
            this.splitContainer1.Panel2.Controls.Add(this.rbtRandomize);
            this.splitContainer1.Panel2.Controls.Add(this.rbtStraigth);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(786, 358);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgwTable12
            // 
            this.dgwTable12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwTable12.Location = new System.Drawing.Point(0, 0);
            this.dgwTable12.Name = "dgwTable12";
            this.dgwTable12.RowHeadersWidth = 102;
            this.dgwTable12.RowTemplate.Height = 25;
            this.dgwTable12.Size = new System.Drawing.Size(542, 358);
            this.dgwTable12.TabIndex = 1;
            this.dgwTable12.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTable12_CellEndEdit);
            this.dgwTable12.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgwTable12_CellValidating);
            this.dgwTable12.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgw_DataError);
            // 
            // rbtProportion
            // 
            this.rbtProportion.AutoSize = true;
            this.rbtProportion.Location = new System.Drawing.Point(17, 57);
            this.rbtProportion.Name = "rbtProportion";
            this.rbtProportion.Size = new System.Drawing.Size(139, 19);
            this.rbtProportion.TabIndex = 4;
            this.rbtProportion.Text = "Пропорциональный";
            this.rbtProportion.UseVisualStyleBackColor = true;
            // 
            // rbtRandomize
            // 
            this.rbtRandomize.AutoSize = true;
            this.rbtRandomize.Location = new System.Drawing.Point(17, 81);
            this.rbtRandomize.Name = "rbtRandomize";
            this.rbtRandomize.Size = new System.Drawing.Size(95, 19);
            this.rbtRandomize.TabIndex = 5;
            this.rbtRandomize.Text = "Смешанный";
            this.rbtRandomize.UseVisualStyleBackColor = true;
            // 
            // rbtStraigth
            // 
            this.rbtStraigth.AutoSize = true;
            this.rbtStraigth.Checked = true;
            this.rbtStraigth.Location = new System.Drawing.Point(17, 33);
            this.rbtStraigth.Name = "rbtStraigth";
            this.rbtStraigth.Size = new System.Drawing.Size(70, 19);
            this.rbtStraigth.TabIndex = 3;
            this.rbtStraigth.TabStop = true;
            this.rbtStraigth.Text = "Прямой";
            this.rbtStraigth.UseVisualStyleBackColor = true;
            // 
            // tabPageOption3
            // 
            this.tabPageOption3.Controls.Add(this.lblAmount);
            this.tabPageOption3.Controls.Add(this.tbxAmount);
            this.tabPageOption3.Controls.Add(this.rbtTemplate);
            this.tabPageOption3.Controls.Add(this.rbtLength);
            this.tabPageOption3.Controls.Add(this.tbxTemplate);
            this.tabPageOption3.Controls.Add(this.tbxLength);
            this.tabPageOption3.Controls.Add(this.lblRange);
            this.tabPageOption3.Controls.Add(this.tbxRange);
            this.tabPageOption3.Location = new System.Drawing.Point(4, 24);
            this.tabPageOption3.Name = "tabPageOption3";
            this.tabPageOption3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageOption3.Size = new System.Drawing.Size(792, 364);
            this.tabPageOption3.TabIndex = 1;
            this.tabPageOption3.Text = "Code generation";
            this.tabPageOption3.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(2, 140);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 15);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Количество кодов:";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(124, 136);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.PlaceholderText = "задайте количество";
            this.tbxAmount.Size = new System.Drawing.Size(100, 23);
            this.tbxAmount.TabIndex = 9;
            this.tbxAmount.Text = "1000";
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // rbtTemplate
            // 
            this.rbtTemplate.AutoSize = true;
            this.rbtTemplate.Checked = true;
            this.rbtTemplate.Location = new System.Drawing.Point(37, 103);
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
            this.rbtLength.Location = new System.Drawing.Point(37, 68);
            this.rbtLength.Name = "rbtLength";
            this.rbtLength.Size = new System.Drawing.Size(63, 19);
            this.rbtLength.TabIndex = 7;
            this.rbtLength.Text = "Длина:";
            this.rbtLength.UseVisualStyleBackColor = true;
            // 
            // tbxTemplate
            // 
            this.tbxTemplate.Location = new System.Drawing.Point(124, 102);
            this.tbxTemplate.Name = "tbxTemplate";
            this.tbxTemplate.PlaceholderText = "задайте шаблон";
            this.tbxTemplate.Size = new System.Drawing.Size(100, 23);
            this.tbxTemplate.TabIndex = 4;
            this.tbxTemplate.Text = "!!@!!!";
            this.tbxTemplate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTemplate_KeyPress);
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(125, 66);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.PlaceholderText = "задайте длину";
            this.tbxLength.Size = new System.Drawing.Size(99, 23);
            this.tbxLength.TabIndex = 2;
            this.tbxLength.Text = "3";
            this.tbxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(2, 32);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(121, 15);
            this.lblRange.TabIndex = 1;
            this.lblRange.Text = "Диапазон символов:";
            // 
            // tbxRange
            // 
            this.tbxRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRange.Location = new System.Drawing.Point(134, 28);
            this.tbxRange.Name = "tbxRange";
            this.tbxRange.PlaceholderText = "введите все допустимые символы";
            this.tbxRange.Size = new System.Drawing.Size(654, 23);
            this.tbxRange.TabIndex = 0;
            this.tbxRange.Text = "AZVREBNKLYURDWXvgfht1236789";
            this.tbxRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRange_KeyPress);
            // 
            // tabPageOption4
            // 
            this.tabPageOption4.Controls.Add(this.dgwTable4);
            this.tabPageOption4.Location = new System.Drawing.Point(4, 24);
            this.tabPageOption4.Name = "tabPageOption4";
            this.tabPageOption4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageOption4.Size = new System.Drawing.Size(792, 364);
            this.tabPageOption4.TabIndex = 2;
            this.tabPageOption4.Text = "Adv campaign (split)";
            this.tabPageOption4.UseVisualStyleBackColor = true;
            // 
            // dgwTable4
            // 
            this.dgwTable4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwTable4.Location = new System.Drawing.Point(3, 3);
            this.dgwTable4.Name = "dgwTable4";
            this.dgwTable4.RowHeadersWidth = 102;
            this.dgwTable4.RowTemplate.Height = 25;
            this.dgwTable4.Size = new System.Drawing.Size(786, 358);
            this.dgwTable4.TabIndex = 0;
            this.dgwTable4.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgw_DataError);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFile.CausesValidation = false;
            this.btnSaveFile.Location = new System.Drawing.Point(683, 21);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // btnSaveCodes
            // 
            this.btnSaveCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCodes.Location = new System.Drawing.Point(683, 19);
            this.btnSaveCodes.Name = "btnSaveCodes";
            this.btnSaveCodes.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCodes.TabIndex = 6;
            this.btnSaveCodes.Text = "Сохранить";
            this.btnSaveCodes.UseVisualStyleBackColor = true;
            this.btnSaveCodes.Visible = false;
            this.btnSaveCodes.Click += new System.EventHandler(this.btnSaveCodes_Click);
            // 
            // btnCreateColumns
            // 
            this.btnCreateColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateColumns.Location = new System.Drawing.Point(247, 12);
            this.btnCreateColumns.Name = "btnCreateColumns";
            this.btnCreateColumns.Size = new System.Drawing.Size(75, 23);
            this.btnCreateColumns.TabIndex = 4;
            this.btnCreateColumns.Text = "Создать";
            this.btnCreateColumns.UseVisualStyleBackColor = true;
            this.btnCreateColumns.Click += new System.EventHandler(this.btnCreateColumns_Click);
            // 
            // lblColumnsCount
            // 
            this.lblColumnsCount.AutoSize = true;
            this.lblColumnsCount.Location = new System.Drawing.Point(11, 16);
            this.lblColumnsCount.Name = "lblColumnsCount";
            this.lblColumnsCount.Size = new System.Drawing.Size(122, 15);
            this.lblColumnsCount.TabIndex = 2;
            this.lblColumnsCount.Text = "Количество колонок";
            // 
            // tbxColumnsCount
            // 
            this.tbxColumnsCount.Location = new System.Drawing.Point(179, 12);
            this.tbxColumnsCount.Name = "tbxColumnsCount";
            this.tbxColumnsCount.Size = new System.Drawing.Size(43, 23);
            this.tbxColumnsCount.TabIndex = 1;
            this.tbxColumnsCount.Text = "5";
            this.tbxColumnsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTable.Location = new System.Drawing.Point(683, 21);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTable.TabIndex = 3;
            this.btnSaveTable.Text = "Сохранить";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Visible = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PCreateAdv);
            this.splitContainer2.Panel2.Controls.Add(this.btnSaveFile);
            this.splitContainer2.Panel2.Controls.Add(this.btnSaveTable);
            this.splitContainer2.Panel2.Controls.Add(this.btnSaveCodes);
            this.splitContainer2.Size = new System.Drawing.Size(800, 450);
            this.splitContainer2.SplitterDistance = 392;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 5;
            // 
            // PCreateAdv
            // 
            this.PCreateAdv.Controls.Add(this.btnCreateColumns);
            this.PCreateAdv.Controls.Add(this.tbxColumnsCount);
            this.PCreateAdv.Controls.Add(this.lblColumnsCount);
            this.PCreateAdv.Location = new System.Drawing.Point(10, 4);
            this.PCreateAdv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PCreateAdv.Name = "PCreateAdv";
            this.PCreateAdv.Size = new System.Drawing.Size(373, 38);
            this.PCreateAdv.TabIndex = 5;
            this.PCreateAdv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.Text = "Scratch.Ua (TM) generation software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOption12.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable12)).EndInit();
            this.tabPageOption3.ResumeLayout(false);
            this.tabPageOption3.PerformLayout();
            this.tabPageOption4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable4)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.PCreateAdv.ResumeLayout(false);
            this.PCreateAdv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SaveFileDialog saveFileDialog;
        private TabControl tabControl1;
        private TabPage tabPageOption12;
        private Button btnSaveFile;
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
        private Button btnCreateColumns;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Panel PCreateAdv;
    }
}