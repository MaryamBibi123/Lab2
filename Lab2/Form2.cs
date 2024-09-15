using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Clear previous results
            resultTextBox.Clear();

            // Input string from TextBox
            string input = inputTextBox.Text;

            // Regular expression for relational operators
            string pattern = @"(<=|>=|==|!=|<|>)";

            // Find matches
            MatchCollection matches = Regex.Matches(input, pattern);

            // Check if any relational operators found
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    // Display found operators in resultTextBox
                    resultTextBox.AppendText(match.Value + Environment.NewLine);
                }
            }
            else
            {
                resultTextBox.Text = "No relational operators found.";
            }
        }
    }
}
