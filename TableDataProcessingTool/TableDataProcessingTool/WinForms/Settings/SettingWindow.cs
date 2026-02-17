using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDataProcessingTool.CSharpFiles.SettingsItems;

namespace TableDataProcessingTool.WinForms.Settings
{
    public partial class SettingWindow: Form
    {
        Main mainWindow;

        public SettingWindow(
            Main main
            )
        {
            InitializeComponent();
            mainWindow = main;

            // Automatic arrange element size on window
            window_width = this.Width;
            window_height = this.Height;
            setTag(this);
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            SettingsItems.backcolor = colorSelectorComboBox.SelectedColor;
            SettingsItems.font = new Font(fontSelectorComboBox.Text, 14.0f);
            mainWindow.ApplySettings();
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
    }
}
