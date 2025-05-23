﻿using System;
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

        //  Reference: https://codereview.stackexchange.com/a/295313/231235
        private static List<double> CellsToNumbers(DataGridViewSelectedCellCollection cells)
        {
            List<double> numbers = new List<double>();
            foreach (DataGridViewCell cell in cells)
            {
                if (Double.TryParse(cell.Value.ToString(), out double result))
                {
                    numbers.Add(result);
                }
            }
            return numbers;
        }

        private double calculateSum(DataGridViewSelectedCellCollection input)
        {
            return CellsToNumbers(input).Sum();
        }

        private double? calculateMax(DataGridViewSelectedCellCollection input)
        {
            var numbers = CellsToNumbers(input);
            if (numbers.Count > 0)
            {
                return numbers.Max();
            }
            return null;
        }

        private double? calculateMin(DataGridViewSelectedCellCollection input)
        {
            var numbers = CellsToNumbers(input);
            if (numbers.Count > 0)
            {
                return numbers.Min();
            }
            return null;
        }

        private Tuple<double, double> calculateMinMax(DataGridViewSelectedCellCollection input)
        {
            var numbers = CellsToNumbers(input);
            if (numbers.Count > 0)
            {
                return new Tuple<double, double>(numbers.Min(), numbers.Max());
            }
            return null;
        }

        private double? calculateStandardDeviation(DataGridViewSelectedCellCollection input)
        {
            List<double> numbers = CellsToNumbers(input);
            if (numbers.Count > 0)
            {
                return StandardDeviation(numbers);
            }
            return null;
        }

        //  StandardDeviation method
        private static double StandardDeviation(double[] doubles)
        {
            double average = doubles.Average();
            double sumOfSquaresOfDifferences = doubles.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / doubles.Length);
            return sd;
        }

        //  StandardDeviation method
        private static double StandardDeviation(IEnumerable<double> doubles)
        {
            return StandardDeviation(doubles.ToArray());
        }

        private static double StandardDeviation(IEnumerable<decimal> decimals)
        {
            decimal average = decimals.Average();
            decimal sumOfSquaresOfDifferences = decimals.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt((double)sumOfSquaresOfDifferences / decimals.Count());
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
