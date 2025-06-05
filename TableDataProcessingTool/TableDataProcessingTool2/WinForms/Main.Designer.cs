namespace TableDataProcessingTool2
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            groupBox_filelist = new GroupBox();
            listBox_FileList = new ListBox();
            button_SelectedCellsInfo = new Button();
            SheetSelectorComboBox = new ComboBox();
            dataGridView_Main = new DataGridView();
            label_selectedCellCount = new Label();
            label_cellSum = new Label();
            groupBox_filelist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Main).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // groupBox_filelist
            // 
            groupBox_filelist.Controls.Add(listBox_FileList);
            groupBox_filelist.Location = new Point(12, 27);
            groupBox_filelist.Name = "groupBox_filelist";
            groupBox_filelist.Size = new Size(197, 411);
            groupBox_filelist.TabIndex = 1;
            groupBox_filelist.TabStop = false;
            groupBox_filelist.Text = "File List";
            // 
            // listBox_FileList
            // 
            listBox_FileList.FormattingEnabled = true;
            listBox_FileList.Location = new Point(6, 22);
            listBox_FileList.Name = "listBox_FileList";
            listBox_FileList.ScrollAlwaysVisible = true;
            listBox_FileList.Size = new Size(185, 379);
            listBox_FileList.TabIndex = 0;
            listBox_FileList.SelectedIndexChanged += listBox_FileList_SelectedIndexChanged;
            // 
            // button_SelectedCellsInfo
            // 
            button_SelectedCellsInfo.Location = new Point(713, 415);
            button_SelectedCellsInfo.Name = "button_SelectedCellsInfo";
            button_SelectedCellsInfo.Size = new Size(75, 23);
            button_SelectedCellsInfo.TabIndex = 2;
            button_SelectedCellsInfo.Text = "Info";
            button_SelectedCellsInfo.UseVisualStyleBackColor = true;
            button_SelectedCellsInfo.Click += button_SelectedCellsInfo_Click;
            // 
            // SheetSelectorComboBox
            // 
            SheetSelectorComboBox.FormattingEnabled = true;
            SheetSelectorComboBox.Location = new Point(215, 27);
            SheetSelectorComboBox.Name = "SheetSelectorComboBox";
            SheetSelectorComboBox.Size = new Size(229, 23);
            SheetSelectorComboBox.TabIndex = 3;
            SheetSelectorComboBox.SelectedIndexChanged += SheetSelectorComboBox_SelectedIndexChanged;
            // 
            // dataGridView_Main
            // 
            dataGridView_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Main.Location = new Point(215, 56);
            dataGridView_Main.Name = "dataGridView_Main";
            dataGridView_Main.Size = new Size(573, 344);
            dataGridView_Main.TabIndex = 4;
            dataGridView_Main.CellEnter += dataGridView_Main_CellEnter;
            dataGridView_Main.CellLeave += dataGridView_Main_CellLeave;
            dataGridView_Main.CellMouseDown += dataGridView_Main_CellMouseDown;
            // 
            // label_selectedCellCount
            // 
            label_selectedCellCount.AutoSize = true;
            label_selectedCellCount.Location = new Point(555, 403);
            label_selectedCellCount.Name = "label_selectedCellCount";
            label_selectedCellCount.Size = new Size(104, 15);
            label_selectedCellCount.TabIndex = 5;
            label_selectedCellCount.Text = "SelectedCellCount";
            // 
            // label_cellSum
            // 
            label_cellSum.AutoSize = true;
            label_cellSum.Location = new Point(555, 423);
            label_cellSum.Name = "label_cellSum";
            label_cellSum.Size = new Size(54, 15);
            label_cellSum.TabIndex = 6;
            label_cellSum.Text = "Cell Sum";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_cellSum);
            Controls.Add(label_selectedCellCount);
            Controls.Add(dataGridView_Main);
            Controls.Add(SheetSelectorComboBox);
            Controls.Add(button_SelectedCellsInfo);
            Controls.Add(groupBox_filelist);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "MainUI";
            Resize += Form_Resize;
            groupBox_filelist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox groupBox_filelist;
        private ListBox listBox_FileList;
        private Button button_SelectedCellsInfo;
        private ComboBox SheetSelectorComboBox;
        private DataGridView dataGridView_Main;
        private Label label_selectedCellCount;
        private Label label_cellSum;
    }
}
