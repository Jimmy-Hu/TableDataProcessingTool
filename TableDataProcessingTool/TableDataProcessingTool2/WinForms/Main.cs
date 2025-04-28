using TableDataProcessingTool2.CSharpFiles;

namespace TableDataProcessingTool2
{
    public partial class Main : Form
    {
        private readonly bool IsDebugMode = false;
        private readonly List<CSharpFiles.SheetFileStructure> PreloadData = new List<SheetFileStructure>();
        private const int PreloadDataMaximunCount = 100;
        private TableDataProcessingTool2.CSharpFiles.BlockStructure MainBlockStructure;
        private string ActiveSheetName;


        public Main()
        {
            InitializeComponent();
            var titleItem_File = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "File",
                Text = "File",
            };
            menuStrip1.Items.Add(titleItem_File);
            var titleItem_File_Open = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "Open",
                Text = "Open"
            };
            titleItem_File.DropDownItems.Add(titleItem_File_Open);
            titleItem_File_Open.Click += new EventHandler(delegate (Object o, EventArgs arg)        //  Open option
            {
                const bool EnableReadingXLSFile = true;
                const bool EnableReadingXLSXFile = true;

                foreach (string fileName in SelectMultipleSheetsFile())
                {
                    if (
                        (
                            System.IO.Path.GetExtension(fileName).Equals(".xls") ||     //    Accept .xls file format
                            System.IO.Path.GetExtension(fileName).Equals(".xlsx") ||    //    Accept .xlsx file format
                            System.IO.Path.GetExtension(fileName).Equals(".sheets2")    //    Accept .sheets2 file format
                        ).Equals(false) ||
                        fileName.Contains("~$") ||
                        PreloadData.Count >= PreloadDataMaximunCount
                        )
                    {
                        continue;
                    }

                    if (EnableReadingXLSFile.Equals(false) && System.IO.Path.GetExtension(fileName).Equals(".xls"))
                    {
                        continue;
                    }

                    if (EnableReadingXLSXFile.Equals(false) && System.IO.Path.GetExtension(fileName).Equals(".xlsx"))
                    {
                        continue;
                    }


                    //    Preload data
                    PreloadData.Add(new CSharpFiles.SheetFileStructure(fileName));

                    //    Add items to listBox
                    listBox_FileList.Items.Add(fileName);
                }
            });

            var titleItem_Window = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "Window",
                Text = "Window",
            };
            menuStrip1.Items.Add(titleItem_Window);

            var titleItem_Window_FileConverter = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "FileConverter",
                Text = "File Converter"
            };
            titleItem_Window.DropDownItems.Add(titleItem_Window_FileConverter);
            titleItem_Window_FileConverter.Click += new EventHandler(delegate (Object o, EventArgs arg)
            {
                FileConverter fileConverterObject = new FileConverter();
                fileConverterObject.Show();
            });
            /// title list "Settings"
            var titleItem_Settings = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "Settings",
                Text = "Settings",
            };
            menuStrip1.Items.Add(titleItem_Settings);
            titleItem_Settings.Click += new EventHandler(delegate (Object o, EventArgs arg)
            {
                //WinForms.Settings.SettingWindow settings = new WinForms.Settings.SettingWindow(this);
                //settings.Show();
            });

            button_SelectedCellsInfo.Enabled = false;
            // Automatic arrange element size on window
            window_width = this.Width;
            window_height = this.Height;
            setTag(this);
        }

        public void ApplySettings()
        {
            this.BackColor = SettingsItems.backcolor;
            if (SettingsItems.backgroundImage != null)
            {
                this.BackgroundImage = SettingsItems.backgroundImage;
            }
            if (SettingsItems.font != null)                 //  Apply font
            {
                this.Font = SettingsItems.font;
                this.groupBox_filelist.Font = this.Font;
            }
        }

        private string[] SelectMultipleSheetsFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Input File";
            openFileDialog1.Filter = "sheets files (*.sheets2)|*.sheets2|Excel Files (*.xlsx)|*.xlsx";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            return openFileDialog1.FileNames;
        }

        #region -- Automatic arrange element size on window --
        private readonly float window_width;
        private readonly float window_height;

        private void setTag(System.Windows.Forms.Control cons)
        {
            foreach (System.Windows.Forms.Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0) setTag(con);
            }
        }

        private void setControls(float new_window_width_ratio, float new_window_height_ratio, System.Windows.Forms.Control cons)
        {
            foreach (System.Windows.Forms.Control con in cons.Controls)
            {
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * new_window_width_ratio);  // width
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * new_window_height_ratio);  // height
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * new_window_width_ratio);  // left
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * new_window_height_ratio);  // top
                    Single new_font_size = System.Convert.ToSingle(mytag[4]) * new_window_height_ratio;  // font size
                    con.Font = new Font(con.Font.Name, new_font_size, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0) setControls(new_window_width_ratio, new_window_height_ratio, con);
                }
            }
        }

        //  Form_Resize method implementation 
        private void Form_Resize(object sender, EventArgs e)
        {
            setControls((this.Width) / window_width, (this.Height) / window_height, this);
        }

        #endregion

        private void listBox_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listBox_FileList.GetItemText(listBox_FileList.SelectedItem)))
            {
                return;
            }
            this.SheetSelectorComboBox.Items.Clear();
            foreach (var EachSheet in this.PreloadData[listBox_FileList.SelectedIndex].GetSheetStructures())
            {
                this.SheetSelectorComboBox.Items.Add(EachSheet.GetSheetName());
            }
            this.SheetSelectorComboBox.Text = this.PreloadData[listBox_FileList.SelectedIndex].GetSheetStructure(0).GetSheetName();
            this.ActiveSheetName = listBox_FileList.GetItemText(listBox_FileList.SelectedItem);
            button_SelectedCellsInfo.Enabled = true;
        }

        private void SheetSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MainBlockStructure = this.PreloadData[listBox_FileList.SelectedIndex].GetSheetStructureByName(this.SheetSelectorComboBox.Text).GetBlockStructure();
            this.MainBlockStructure.ShowDataGridView(ref this.dataGridView_Main);
        }

        private void dataGridView_Summary(ref DataGridView dataGridView)
        {
            label_selectedCellCount.Text = dataGridView.SelectedCells.Count.ToString() + " cell selected";
            decimal sum = 0;
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                if (MainBlockStructure.GetCell(cell.ColumnIndex, cell.RowIndex).GetDecimal().HasValue)
                {
                    sum += MainBlockStructure.GetCell(cell.ColumnIndex, cell.RowIndex).GetDecimal().Value;
                }
            }
            label_cellSum.Text = "Sum: " + sum.ToString();
        }

        private void dataGridView_Main_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView_Summary(ref dataGridView_Main);
        }

        private void dataGridView_Main_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Summary(ref dataGridView_Main);
        }

        private void dataGridView_Main_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Summary(ref dataGridView_Main);
        }

        private void button_SelectedCellsInfo_Click(object sender, EventArgs e)
        {
            //SelectedCellsInfo selectedCellsInfo = new SelectedCellsInfo(dataGridView_Main.SelectedCells);
            //selectedCellsInfo.Show();
        }
    }
}
