using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataProcessingTool.ExtendedComponents
{
    public class FontSelectorComboBox : ComboBox
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            DropDownStyle = ComboBoxStyle.DropDownList; // Don't let the user type an invalid value.

            // Reference: https://stackoverflow.com/a/4667601/6667035
            DrawMode = DrawMode.OwnerDrawFixed;

            // Get the installed font families.
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            // Add the font families to the ComboBox.
            foreach (FontFamily fontFamily in installedFontCollection.Families)
            {
                Items.Add(fontFamily.Name);
            }
            
            SelectedIndex = FindStringExact("Calibri");
            DrawItem += DrawThisItem;
        }

        protected override void Dispose(bool disposing)
        {
            DrawItem -= DrawThisItem;
            base.Dispose(disposing);
        }

        private void DrawThisItem(object sender, DrawItemEventArgs e)
        {
            // Get the item text
            string text = ((ComboBox)sender).Items[e.Index].ToString();

            // Draw the text
            e.Graphics.DrawString(
                text,
                new Font(text, 14.0f, FontStyle.Regular),
                Brushes.Black, // Background color is too dark
                e.Bounds.X,
                e.Bounds.Y,
                StringFormat.GenericDefault);
        }
    }
}
