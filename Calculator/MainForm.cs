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
using TextChanger;

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "0";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxEntry.Text.Length > 1)
                textBoxEntry.Text = textBoxEntry.Text.Remove(textBoxEntry.Text.Length - 1, 1);
            else
                textBoxEntry.Text = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            entryFieldAddText("+");
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            /*if (!textBoxEntry.Text.Contains("="))
            {
                answer = StringExpressionSolver.GetAnswer(textBoxEntry.Text);
                textBoxEntry.Text += "=";
                textBoxResult.Text = answer.ToString();
            }*/
            //НУЖНО прогнать цикл на поиск скобок и если есть сразу срываться
            //с цикла и начинать подсчет открывающих и закрывающих скобок 
            //и использовать метод со скобками, если их количество равно
            //если нет скобок, то без них
            //НУЖНО добавить - если в поле просто число, то ничего не делать
            if (!textBoxEntry.Text.Contains("="))
            {
                //answer = StringExpressionSolver.GetAnswer(textBoxEntry.Text);
                answer = StringExpressionSolver.GetAnswerWithBrackets(textBoxEntry.Text);
                textBoxEntry.Text += "=";
                textBoxResult.Text = answer.ToString();
            }
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
            char[] arrayChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', ',' };
            if (textBoxEntry.Text == "0")
            {
                textBoxEntry.Text = "(";
            }
            else if (!arrayChars.Contains(textBoxEntry.Text[textBoxEntry.Text.Length - 1]))
            {
                textBoxEntry.Text += "(";
            }
        }

        private void buttonClBracket_Click(object sender, EventArgs e)
        {
            //НУЖНО доделать ставить закрывающую скобку после чисел, только если в строке есть
            //открывающая скобка и математические операторы
            char[] arrayChars = { '(', ',', '+', '-', '*', '/' };
            if (!arrayChars.Contains(textBoxEntry.Text[textBoxEntry.Text.Length - 1]) &&
                textBoxEntry.Text != "0")
            {
                textBoxEntry.Text += ")";
            }
            
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            char[] arrayNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] arrayChars = { '-', '+', '*', '/', '(' };
            if (arrayNums.Contains(textBoxEntry.Text[textBoxEntry.Text.Length - 1]))
            {
                string[] members = textBoxEntry.Text.Split(new char[] { '-', '+', '*', '/', '(', ')' },
                    StringSplitOptions.RemoveEmptyEntries);
                if (!members[members.Length - 1].Contains(","))
                    textBoxEntry.Text += ",";
            }
            else if (arrayChars.Contains(textBoxEntry.Text[textBoxEntry.Text.Length - 1]))
            {
                    textBoxEntry.Text += "0,";
            }
        }

        private void entryFieldAddText(string sent)
        {
            //дописать если стоит ноль, ничем не закрытый, то ноль убрать
            textBoxEntry.Text = StringExpressionChanger.AddToExpression(textBoxEntry.Text,
                textBoxEntry.SelectionStart, sent);
            textBoxEntry.SelectionStart = textBoxEntry.Text.Length;
            textBoxEntry.SelectionLength = 0;
            textBoxEntry.Focus();
        }

        private void entryFieldAddingOperator(char sent)
        {
            /*char[] arrayChar = { '*', '+', '-', '/' };
            if (arrayChar.Contains(textBoxEntry.Text[textBoxEntry.Text.Length - 1]))
            {
                textBoxEntry.Text = textBoxEntry.Text.Remove(textBoxEntry.Text.Length - 1);
                textBoxEntry.Text += sent;
            }
            else if (textBoxEntry.Text[textBoxEntry.Text.Length - 1] == ',' ||
                textBoxEntry.Text[textBoxEntry.Text.Length - 1] == '(')
            {
                //так и задумано - ничего не делаем
            }
            else
            {
                textBoxEntry.Text += sent;
            }*/
        }

        private void makeNumberNegative ()
        {
            //если поле ввода не содержит ничего, кроме цифр и запятой
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            MoveCursor(true);
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            MoveCursor(false);
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
    }
}
