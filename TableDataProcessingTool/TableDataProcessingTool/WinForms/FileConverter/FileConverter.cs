using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataProcessingTool
{
    public partial class FileConverter : Form
    {
        private bool SingleSelectionMode = false;
        private BackgroundWorker backgroundWorker = new BackgroundWorker();

        public FileConverter()
        {
            InitializeComponent();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            if (SingleSelectionMode == true)
            {
                textBox1.Text = SelectXLSXFile();
            }
            else
            {
                foreach (var item in SelectMutipleXLSXFile())
                {
                    textBox1.AppendText("\"" + item + "\",");
                }
            }
        }

        private string SelectXLSXFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Input File";
            openFileDialog1.Filter = "xls files (*.xls)|*.xls|xlsx files (*.xlsx*)|*.xlsx*";
            openFileDialog1.ShowDialog();
            return openFileDialog1.FileName;
        }

        private string[] SelectMutipleXLSXFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Input File";
            List<string> FilterContents = new List<string>();
            FilterContents.Add("csv");
            FilterContents.Add("xls");
            FilterContents.Add("xlsx");
            FilterContents.Add("xlsm");
            string FilterString = "";
            foreach (var EachFilterContents in FilterContents)
            {
                FilterString += EachFilterContents + " files (*." + EachFilterContents + ")|*." + EachFilterContents + "|";
            }
            FilterString = FilterString.Substring(0, FilterString.Length - 1);
            openFileDialog1.Filter = FilterString;
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            return openFileDialog1.FileNames;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == true)                    //    Without selecting file
            {
                MessageBox.Show("Please select file!");
                return;
            }
            UpdateUIComponents(ConvertButton, BrowseFileButton, textBox1);

            if (checkBox1.Checked)
            {
                List<string> SplitByCommon = textBox1.Text.Split(',').ToList();
                List<string> FilenameList = new List<string>();

                foreach (var item in SplitByCommon)
                {
                    if (string.IsNullOrEmpty(item))
                    {
                        continue;
                    }
                    FilenameList.Add(item);
                }
                List<string> OutputFoldersList = new List<string>();
                foreach (var eachFilename in FilenameList)
                {
                    //MessageBox.Show(new System.IO.FileInfo(eachFilename.Replace("\"", "")).DirectoryName);
                    OutputFoldersList.Add(new System.IO.FileInfo(eachFilename.Replace("\"", "")).DirectoryName);
                }
                //    Setup: Config progressbar
                this.progressBar1.Maximum = SplitByCommon.Count - 2;
                this.progressBar1.Minimum = 0;
                backgroundWorker.WorkerReportsProgress = true;

                //    Setup: Construct object for passing to worker
                var ObjectForPassing = new List<Tuple<string, string>>();
                foreach (var eachFilename in FilenameList.Select((Value, Index) => new { Index, Value }))
                {
                    string SourceFilename = eachFilename.Value;
                    string OutputPath = OutputFoldersList[eachFilename.Index];
                    //MessageBox.Show($"SourceFilename: {SourceFilename}\nOutputPath: {OutputPath}");
                    ObjectForPassing.Add(new Tuple<string, string>(OutputPath, SourceFilename));
                }
                backgroundWorker.RunWorkerAsync(ObjectForPassing);
            }
            else
            {
                //    The version with selecting output folder
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK &&
                    String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath) == false)
                {
                    string OutputFolder = folderBrowserDialog1.SelectedPath;
                    string InputFilenames = textBox1.Text;

                    List<string> FilenameList = InputFilenames.Split(',').ToList<string>();

                    //    Setup: Config progressbar
                    this.progressBar1.Maximum = FilenameList.Count - 2;
                    this.progressBar1.Minimum = 0;
                    backgroundWorker.WorkerReportsProgress = true;
                    var ObjectForPassing = new Tuple<string, List<string>>(OutputFolder, FilenameList);
                    backgroundWorker.RunWorkerAsync(ObjectForPassing);
                }
                else
                {
                    //  Back to normal mode
                    ConvertButton.Text = "Convert";
                    BrowseFileButton.Enabled = true;
                    textBox1.Enabled = true;
                }
            }
        }

        private void UpdateUIComponents(
            System.Windows.Forms.Button ConvertButton,
            System.Windows.Forms.Button BrowseFileButton,
            TextBox textBox1)
        {
            if (backgroundWorker.IsBusy.Equals(true))
            {
                backgroundWorker.CancelAsync();
            }
            //    Update UI components
            ConvertButton.Text = "Cancel";
            BrowseFileButton.Enabled = false;
            textBox1.Enabled = false;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkBox1.Checked)
            {
                var Arguments = e.Argument as List<Tuple<string, string>>;

                foreach (var EachFile in Arguments.Select((Value, Index) => new { Index, Value }))
                {
                    string NameOfFileForProcessing = EachFile.Value.Item2.Replace("\"", "");
                    if (String.IsNullOrEmpty(NameOfFileForProcessing) == true)
                    {
                        continue;
                    }

                    new CSharpFiles.FileConverter(NameOfFileForProcessing, EachFile.Value.Item1);

                    //    Report progress
                    backgroundWorker.ReportProgress(EachFile.Index, NameOfFileForProcessing + '\t' + " file convertion finished." + System.Environment.NewLine);
                }
            }
            else
            {
                var Arguments = e.Argument as Tuple<string, List<string>>;
                var OutputFolder = Arguments.Item1;
                var FilenameList = Arguments.Item2;

                foreach (var EachFile in FilenameList.Select((Value, Index) => new { Index, Value }))
                {
                    string NameOfFileForProcessing = EachFile.Value.Replace("\"", "");
                    if (String.IsNullOrEmpty(NameOfFileForProcessing) == true)
                    {
                        continue;
                    }

                    new CSharpFiles.FileConverter(NameOfFileForProcessing, OutputFolder);

                    //    Report progress
                    backgroundWorker.ReportProgress(EachFile.Index, NameOfFileForProcessing + '\t' + " file convertion finished." + System.Environment.NewLine);
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.ProcessingInfo.AppendText(e.UserState.ToString());
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("All tasks finished.");
            textBox1.Text = "";
            BrowseFileButton.Enabled = true;
            ConvertButton.Text = "Convert";

        }

    }
}
