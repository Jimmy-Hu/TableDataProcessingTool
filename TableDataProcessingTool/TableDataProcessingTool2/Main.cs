namespace TableDataProcessingTool2
{
    public partial class Main : Form
    {
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
            });
        }
    }
}
