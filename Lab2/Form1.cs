using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Clear previous results
            resultTextBox.Clear();

            // Input string from TextBox
            string input = inputTextBox.Text;

            // Regular expression for logical operators
            string logicalPattern = @"(&&|\|\||!)";

            // Regular expression for relational operators
            string relationalPattern = @"(<=|>=|==|!=|<|>)";

            // Find matches for logical operators
            MatchCollection logicalMatches = Regex.Matches(input, logicalPattern);

            // Find matches for relational operators
            MatchCollection relationalMatches = Regex.Matches(input, relationalPattern);

            // Display logical operators
            resultTextBox.AppendText("Logical Operators:\n");
            if (logicalMatches.Count > 0)
            {
                foreach (Match match in logicalMatches)
                {
                    resultTextBox.AppendText(match.Value + Environment.NewLine);
                }
            }
            else
            {
                resultTextBox.AppendText("No logical operators found.\n");
            }

            // Display relational operators
            resultTextBox.AppendText("\nRelational Operators:\n");
            if (relationalMatches.Count > 0)
            {
                foreach (Match match in relationalMatches)
                {
                    resultTextBox.AppendText(match.Value + Environment.NewLine);
                }
            }
            else
            {
                resultTextBox.AppendText("No relational operators found.\n");
            }
        }
    }
}
