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
            textBoxEntry.SelectionStart = textBoxEntry.Text.Length;
            textBoxEntry.SelectionLength = 0;
            textBoxEntry.Focus();
        }

        //нужна ли эта переменная?
        static double answer;

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
            textBoxEntry.Clear();
            textBoxEntry.SelectionStart = textBoxEntry.Text.Length;
            textBoxEntry.SelectionLength = 0;
            textBoxEntry.Focus();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            int position = textBoxEntry.SelectionStart;
            if (textBoxEntry.SelectionStart > 0)
            {   
                textBoxEntry.Text = textBoxEntry.Text.Remove(position - 1, 1);
                textBoxEntry.SelectionStart = position - 1;
                textBoxEntry.SelectionLength = 0;
                textBoxEntry.Focus();
            }
            else
            {
                textBoxEntry.SelectionStart = position;
                textBoxEntry.SelectionLength = 0;
                textBoxEntry.Focus();
            }
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            /*if (!textBoxEntry.Text.Contains("="))
            {
                answer = StringExpressionSolver.GetAnswer(textBoxEntry.Text);
                textBoxEntry.Text += "=";
                textBoxResult.Text = answer.ToString();
            }*/
            //сделать проверку синтаксиса, в случае ошибок выводить предупреждение
            //НУЖНО прогнать цикл на поиск скобок и если есть сразу срываться
            //с цикла и начинать подсчет открывающих и закрывающих скобок 
            //и использовать метод со скобками, если их количество равно
            //если нет скобок, то без них
            //НУЖНО добавить - если в поле просто число, то ничего не делать

            //цикл подсчёта открывающих и закрывающих скобок
            int opBr = 0, clBr = 0;
            for (int i = 0; i < textBoxEntry.Text.Length; i++)
            {
                if (textBoxEntry.Text[i] == '(')
                    opBr++;
                if (textBoxEntry.Text[i] == ')')
                    clBr++;
            }

            int position = textBoxEntry.SelectionStart;

            if (!textBoxEntry.Text.Contains("=") && opBr == clBr && 
                !CorrectSpellingExpressionChecker.CheckCorrectSpellingExpression(textBoxEntry.Text))
            {
                //answer = StringExpressionSolver.GetAnswer(textBoxEntry.Text);
                answer = StringExpressionSolver.GetAnswerWithBrackets(textBoxEntry.Text);
                textBoxEntry.Text += "=";
                textBoxResult.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("Syntax error!", "Attention!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEntry.SelectionStart = position;
                textBoxEntry.SelectionLength = 0;
                textBoxEntry.Focus();
            }
        }

        private void entryFieldAddText(string sent)
        {
            int position = textBoxEntry.SelectionStart;
            textBoxEntry.Text = textBoxEntry.Text.Insert(position, sent);
            textBoxEntry.SelectionStart = position + 1;
            textBoxEntry.SelectionLength = 0;
            textBoxEntry.Focus();
        }

        private void MoveCursor (bool toLeft)
        {
            if (toLeft)
            {
                if (textBoxEntry.SelectionStart != 0)
                    textBoxEntry.SelectionStart--;
            }
            else
            {
                if (textBoxEntry.SelectionStart != textBoxEntry.Text.Length)
                    textBoxEntry.SelectionStart++;
            }
            textBoxEntry.SelectionLength = 0;
            textBoxEntry.Focus();
        }

        private bool CheckCorrectSpelling ()
        {
            bool check = false;
            //неравное количество открывающих и закрывающих скобок
            //начинается или заканчивается на оператор (кроме минуса), запятую
            //начинается на закрывающую скобку
            //заканчивается на открывающую скобку


            for (int i = 0; i < textBoxEntry.Text.Length - 1; i++)
            {
                if (textBoxEntry.Text[i] == '(')
                    check = true;
            }

            return check;
        }
    }
}
