using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solver;
using SpellingChecker;

namespace Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            textBoxEntry.SetCursor(textBoxEntry.Text.Length);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            entryFieldAddText("0");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            entryFieldAddText("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            entryFieldAddText("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            entryFieldAddText("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            entryFieldAddText("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            entryFieldAddText("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            entryFieldAddText("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            entryFieldAddText("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            entryFieldAddText("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            entryFieldAddText("9");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            entryFieldAddText("+");
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            entryFieldAddText("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            entryFieldAddText("/");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            entryFieldAddText("-");
        }

        private void buttonOpBracket_Click(object sender, EventArgs e)
        {
            entryFieldAddText("(");
        }

        private void buttonClBracket_Click(object sender, EventArgs e)
        {
            entryFieldAddText(")");
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            entryFieldAddText(",");
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            MoveCursor(true);
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            MoveCursor(false);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            textBoxEntry.Clear();
            textBoxEntry.SetCursor(textBoxEntry.Text.Length);
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            int position = textBoxEntry.SelectionStart;
            if (textBoxEntry.SelectionStart > 0)
            {   
                textBoxEntry.Text = textBoxEntry.Text.Remove(position - 1, 1);
                textBoxEntry.SetCursor(position - 1);
            }
            else
            {
                textBoxEntry.SetCursor(position);
            }
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            //НУЖНО добавить - если в поле просто число, то ничего не делать

            int position = textBoxEntry.SelectionStart;

            if (!textBoxEntry.Text.Contains("=") && 
                CorrectSpellingExpressionChecker.SpellingIsCorrect(textBoxEntry.Text))
            {
                string sendingExpression = textBoxEntry.Text;
                double answer = StringExpressionSolver.GetAnswer(sendingExpression);
                textBoxEntry.Text += "=";
                textBoxResult.Text = answer.ToString();
                textBoxEntry.SetCursor(textBoxEntry.Text.Length);
            }
            else
            {
                MessageBox.Show("Syntax error!", "Attention!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEntry.SetCursor(position);
            }
        }

        private void entryFieldAddText(string sent)
        {
            int position = textBoxEntry.SelectionStart;
            string[] arrayOperators = new string[4] { "-", "+", "*", "/" };
            if (textBoxResult.Text != "" && textBoxEntry.Text.Contains("=") && 
                arrayOperators.Contains(sent))
            {
                //answer = double.Parse(textBoxResult.Text);
                textBoxEntry.Clear();
                textBoxEntry.Text = textBoxResult.Text + sent;
                textBoxEntry.SetCursor(textBoxEntry.Text.Length);
                textBoxResult.Clear();
            }
            else
            {
                textBoxEntry.Text = textBoxEntry.Text.Insert(position, sent);
                textBoxEntry.SetCursor(position + 1);
            }
        }

        private void MoveCursor (bool toLeft)
        {
            if (toLeft)
            {
                if (textBoxEntry.SelectionStart != 0)
                    textBoxEntry.SetCursor(textBoxEntry.SelectionStart - 1);
                else
                    textBoxEntry.SetCursor(textBoxEntry.SelectionStart);
            }
            else
            {
                if (textBoxEntry.SelectionStart != textBoxEntry.Text.Length)
                    textBoxEntry.SetCursor(textBoxEntry.SelectionStart + 1);
                else
                    textBoxEntry.SetCursor(textBoxEntry.SelectionStart);
            }
        }
    }
    public static class ExtensionTextBox
    {
        public static void SetCursor (this TextBox textBox, int position)
        {
            textBox.SelectionStart = position;
            textBox.SelectionLength = 0;
            textBox.Focus();
        }
    }
}
