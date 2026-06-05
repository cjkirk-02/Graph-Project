using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When button is clicked, update the graph with the new equation and bounds
            UpdateGraph();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateGraph()
        {
            // Clear existing data points
            chart1.Series[0].Points.Clear();
            // Get the equation from the text box
            string equation = textBox1.Text;
            if ((equation.StartsWith("y = ") || equation.StartsWith("y =") || equation.StartsWith("y=")))
            {
                //Get the graph bounds from the text boxes and parse them
                string xbounds = X_bounds.Text;
                string ybounds = Y_bounds.Text;
                if (xbounds.Length > 0 && ybounds.Length > 0)
                {
                    string x_get = xbounds.Replace("(", "").Replace(")", "");
                    string y_get = ybounds.Replace("(", "").Replace(")", "");
                    string[] x_parts = x_get.Split(',');
                    string[] y_parts = y_get.Split(',');
                    double x_min = double.Parse(x_parts[0], CultureInfo.InvariantCulture);
                    double x_max = double.Parse(x_parts[1], CultureInfo.InvariantCulture);
                    double y_min = double.Parse(y_parts[0], CultureInfo.InvariantCulture);
                    double y_max = double.Parse(y_parts[1], CultureInfo.InvariantCulture);

                    // Generate data points based on the equation
                    for (double x = x_min; x <= x_max; x += 0.1)
                    {
                        double y = EvaluateEquation(equation, x);
                        // Add data point to the chart
                        chart1.Series[0].Points.AddXY(x, y);
                    }

                }
                else
                    MessageBox.Show("Please enter valid bounds for both X and Y axes in the form '(min,max)'.",
                        "Warning: Invalid Bounds",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
            }
            else
                MessageBox.Show("Please enter an equation in the form 'y = ...' to graph.",
                    "Warning: Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

        }

        private double EvaluateEquation(string equation, double x)
        {
            // Support simple linear-like equations with multiple additive terms.
            // Examples supported:
            //  y = 2x+3
            //  y = x + 4 - 1
            //  y = 3 + 4 + 5   (no 'x' term -> constants are summed)

            // Remove the leading 'y=' and whitespace
            string expr = equation.Substring(equation.IndexOf('=') + 1);
            expr = expr.Replace(" ", "");

            if (string.IsNullOrEmpty(expr))
                return 0;

            // Split into terms while keeping signs. Terms are sequences between + or - signs.
            var terms = Regex.Matches(expr, "[+-]?[^+-]+");

            double coeffX = 0.0;
            double constantSum = 0.0;

            foreach (Match m in terms)
            {
                string term = m.Value;
                if (string.IsNullOrWhiteSpace(term))
                    continue;

                // If term contains 'x', parse coefficient; otherwise parse as constant
                if (term.IndexOf('x') >= 0)
                {
                    string coeffPart = term.Replace("x", "");
                    // Handle cases like "x" or "+x" or "-x"
                    if (coeffPart == "" || coeffPart == "+")
                        coeffX += 1.0;
                    else if (coeffPart == "-")
                        coeffX -= 1.0;
                    else
                    {
                        if (double.TryParse(coeffPart, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedCoeff))
                            coeffX += parsedCoeff;
                    }
                }
                else
                {
                    // constant term
                    if (double.TryParse(term, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedConst))
                        constantSum += parsedConst;
                }
            }

            // If there is no x-term, coeffX will be 0 and the result is just the sum of constants.
            return coeffX * x + constantSum;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            // Use MouseEventArgs so we can access X and Y
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            if (result != null && result.ChartElementType == ChartElementType.DataPoint)
            {
                var point = result.Object as DataPoint;
                if (point != null)
                {
                    double xVal = point.XValue;
                    double yVal = point.YValues != null && point.YValues.Length > 0 ? point.YValues[0] : double.NaN;
                    XYcoords.SetToolTip(chart1, $"({xVal:0.00}, {yVal:0.00})");
                    return;
                }
            }

            // Clear tooltip when not over a data point
            XYcoords.SetToolTip(chart1, string.Empty);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
