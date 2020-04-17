using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChanger
{
    public class StringExpressionChanger
    {
        public static string AddToExpression (string incommingExpression, int position, string symbol)
        {
            char[] arrayNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] arrayOperators = { '*', '+', '-', '/' };
            //если прислана цифра
            if (arrayNums.Contains(Convert.ToChar(symbol)))
            {
                incommingExpression = AddNumber(incommingExpression, position, symbol);
            }
            //если прислан оператор
            else if (arrayOperators.Contains(Convert.ToChar(symbol)))
            {
                incommingExpression = AddOperator(incommingExpression, position, symbol);
            }
                return incommingExpression;
        }

        static string AddNumber (string incommingExpression, int position, string symbol)
        {
            //цифру нельзя ставить: 
            //перед открывающей скобкой
            //после закрывающей скобки
            //если место установки - начало числа, то нельзя ставить ноль
            if (incommingExpression == "0")
            {
                incommingExpression = symbol;
            }
            else if (incommingExpression[position - 1] != ')')
                incommingExpression = incommingExpression.Insert(position, symbol);
            return incommingExpression;
        }

        static string AddOperator (string incommingExpression, int position, string symbol)
        {
            char[] arrayChar = { '*', '+', '-', '/' };
            //теперь уже нужно работать не с последним символом, а там, где курсор стоит
            if (arrayChar.Contains(incommingExpression[incommingExpression.Length - 1]))
            {
                incommingExpression = incommingExpression.Remove(incommingExpression.Length - 1);
                incommingExpression += symbol;
            }
            else if (incommingExpression[incommingExpression.Length - 1] == ',' ||
                incommingExpression[incommingExpression.Length - 1] == '(')
            {
                //так и задумано - ничего не делаем
            }
            else
            {
                incommingExpression = incommingExpression.Insert(position, symbol);
            }
            return incommingExpression;
        }


    }
}
