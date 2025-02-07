using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataProcessingTool.WinForms.SelectedCellsInfo
{
    public partial class SelectedCellsInfo: Form
    {
        public SelectedCellsInfo(DataGridViewSelectedCellCollection dataGridViewSelectedCellCollection)
        {
            InitializeComponent();

            label_cellSum.Text = "Sum: " + calculateSum(dataGridViewSelectedCellCollection).ToString();
            var minMax = calculateMinMax(dataGridViewSelectedCellCollection);
            label_cellMin.Text = "Min: " + minMax.Item1.ToString();
            label_cellMax.Text = "Max: " + minMax.Item2.ToString();

            // Automatic arrange element size on window
            window_width = this.Width;
            window_height = this.Height;
            setTag(this);
        }

        private decimal calculateSum(DataGridViewSelectedCellCollection input)
        {
            decimal sum = 0;
            foreach (DataGridViewCell cell in input)
            {
                try
                {
                    sum += decimal.Parse(cell.Value.ToString());
                }
                catch (Exception ex)
                {

                }
            }
            return sum;
        }

        private decimal calculateMax(DataGridViewSelectedCellCollection input)
        {
            List<decimal> numbers = new List<decimal>();
            foreach (DataGridViewCell cell in input)
            {
                try
                {
                    numbers.Add(decimal.Parse(cell.Value.ToString()));
                }
                catch (Exception ex)
                {

                }
            }
            return numbers.Max();
        }

        private decimal calculateMin(DataGridViewSelectedCellCollection input)
        {
            List<decimal> numbers = new List<decimal>();
            foreach (DataGridViewCell cell in input)
            {
                try
                {
                    numbers.Add(decimal.Parse(cell.Value.ToString()));
                }
                catch (Exception ex)
                {

                }
            }
            return numbers.Min();
        }

        private Tuple<decimal, decimal> calculateMinMax(DataGridViewSelectedCellCollection input)
        {
            List<decimal> numbers = new List<decimal>();
            foreach (DataGridViewCell cell in input)
            {
                try
                {
                    numbers.Add(decimal.Parse(cell.Value.ToString()));
                }
                catch (Exception ex)
                {

                }
            }
            return new Tuple<decimal, decimal>(numbers.Min(), numbers.Max());
        }

        //  StandardDeviation method
        public static double StandardDeviation(double[] doubles)
        {
            double average = doubles.Average();
            double sumOfSquaresOfDifferences = doubles.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / doubles.Length);
            return sd;
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
