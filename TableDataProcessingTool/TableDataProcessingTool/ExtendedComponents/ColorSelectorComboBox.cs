using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataProcessingTool.ExtendedComponents
{
    //  Reference: https://codereview.stackexchange.com/a/295138/231235
    public class ColorSelectorComboBox : ComboBox
    {
        public Color SelectedColor { get; private set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            DropDownStyle = ComboBoxStyle.DropDownList; // Don't let the user type an invalid color, only select from known, valid ones.

            // Reference: https://stackoverflow.com/a/4667601/6667035
            DrawMode = DrawMode.OwnerDrawFixed;
            DataSource = Enum
                .GetValues(typeof(KnownColor))
                .Cast<KnownColor>()
                .Select(knowColor => knowColor.ToString())
                .ToList();
            SelectedIndex = FindStringExact("SeaShell");
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Background color is too dark
            const float BrightnessThreshold = 0.3F;

            // Get the item text
            string text = (string)Items[e.Index];

            // Convert it to the color
            SelectedColor = Color.FromName(text);

            // Draw the background
            using (Brush brush = new SolidBrush(SelectedColor))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
            }

            // Draw the text
            e.Graphics.DrawString(
                text,
                Font,
                SelectedColor.GetBrightness() < BrightnessThreshold ? Brushes.White : Brushes.Black,
                e.Bounds.X,
                e.Bounds.Y,
                StringFormat.GenericDefault);
            base.OnDrawItem(e);
        }
    }
}
