namespace TableDataProcessingTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_FileList = new System.Windows.Forms.ListBox();
            this.SheetSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.label_selectedCellCount = new System.Windows.Forms.Label();
            this.label_cellSum = new System.Windows.Forms.Label();
            this.button_SelectedCellsInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MainMenuStrip";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_FileList);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 647);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File List";
            // 
            // listBox_FileList
            // 
            this.listBox_FileList.FormattingEnabled = true;
            this.listBox_FileList.Location = new System.Drawing.Point(1, 20);
            this.listBox_FileList.Name = "listBox_FileList";
            this.listBox_FileList.Size = new System.Drawing.Size(193, 615);
            this.listBox_FileList.TabIndex = 0;
            this.listBox_FileList.SelectedIndexChanged += new System.EventHandler(this.listBox_FileList_SelectedIndexChanged);
            // 
            // SheetSelectorComboBox
            // 
            this.SheetSelectorComboBox.FormattingEnabled = true;
            this.SheetSelectorComboBox.Location = new System.Drawing.Point(219, 47);
            this.SheetSelectorComboBox.Name = "SheetSelectorComboBox";
            this.SheetSelectorComboBox.Size = new System.Drawing.Size(276, 21);
            this.SheetSelectorComboBox.TabIndex = 2;
            this.SheetSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.SheetSelectorComboBox_SelectedIndexChanged);
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.Location = new System.Drawing.Point(219, 75);
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.Size = new System.Drawing.Size(1101, 551);
            this.dataGridView_Main.TabIndex = 3;
            this.dataGridView_Main.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Main_CellEnter);
            this.dataGridView_Main.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Main_CellLeave);
            this.dataGridView_Main.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Main_CellMouseDown);
            // 
            // label_selectedCellCount
            // 
            this.label_selectedCellCount.AutoSize = true;
            this.label_selectedCellCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_selectedCellCount.Location = new System.Drawing.Point(1009, 629);
            this.label_selectedCellCount.Name = "label_selectedCellCount";
            this.label_selectedCellCount.Size = new System.Drawing.Size(166, 24);
            this.label_selectedCellCount.TabIndex = 4;
            this.label_selectedCellCount.Text = "SelectedCellCount";
            // 
            // label_cellSum
            // 
            this.label_cellSum.AutoSize = true;
            this.label_cellSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_cellSum.Location = new System.Drawing.Point(1009, 653);
            this.label_cellSum.Name = "label_cellSum";
            this.label_cellSum.Size = new System.Drawing.Size(86, 24);
            this.label_cellSum.TabIndex = 5;
            this.label_cellSum.Text = "Cell Sum";
            // 
            // button_SelectedCellsInfo
            // 
            this.button_SelectedCellsInfo.Location = new System.Drawing.Point(1245, 656);
            this.button_SelectedCellsInfo.Name = "button_SelectedCellsInfo";
            this.button_SelectedCellsInfo.Size = new System.Drawing.Size(75, 23);
            this.button_SelectedCellsInfo.TabIndex = 6;
            this.button_SelectedCellsInfo.Text = "Info";
            this.button_SelectedCellsInfo.UseVisualStyleBackColor = true;
            this.button_SelectedCellsInfo.Click += new System.EventHandler(this.button_SelectedCellsInfo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 686);
            this.Controls.Add(this.button_SelectedCellsInfo);
            this.Controls.Add(this.label_cellSum);
            this.Controls.Add(this.label_selectedCellCount);
            this.Controls.Add(this.dataGridView_Main);
            this.Controls.Add(this.SheetSelectorComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "TableDataProcessingTool";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_FileList;
        private System.Windows.Forms.ComboBox SheetSelectorComboBox;
        private System.Windows.Forms.DataGridView dataGridView_Main;
        private System.Windows.Forms.Label label_selectedCellCount;
        private System.Windows.Forms.Label label_cellSum;
        private System.Windows.Forms.Button button_SelectedCellsInfo;
    }
}

