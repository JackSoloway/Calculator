using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class StringExpressionSolver
    {
        /// <summary>
        /// Вычисляет выражение, представленное в формате string, без пробелов
        /// и без знака "=" в конце. В выражении допускается наличие скобок.
        /// </summary>
        /// <param name="incomingExpression"></param>
        /// <returns></returns>
        public static double GetAnswer(string incomingExpression)
        {
            int[] arrayPosOB = PositionsOpeningBrackets(incomingExpression);
            for (int i = 0; i < arrayPosOB.Length; i++)
            {
                string tempStr = "";
                double tempAns = 0;
                // Следующий цикл стартует со следующей позиции, указанной в массиве позиций
                // открывающих скобок, растёт на 1 каждую иттерацию
                // и останавливается, когда находит ближайшую закрывающую скобку.
                for (int j = arrayPosOB[arrayPosOB.Length - 1 - i] + 1; 
                    incomingExpression[j] != ')'; j++)
                {
                    tempStr += incomingExpression[j];
                }
                tempAns = GetAnswerWithoutBrackets(tempStr);
                // Далее переписываем incomingExpression:
                // сокращаем incomingExpression на tempStr.Length + 2 позиций
                // и на место "(" вписываем tempAns.
                incomingExpression = incomingExpression.Remove(arrayPosOB[arrayPosOB.Length - 1 - i],
                    tempStr.Length + 2);
                incomingExpression = incomingExpression.Insert(arrayPosOB[arrayPosOB.Length - 1 - i],
                    Convert.ToString(tempAns));
            }
            double answer = GetAnswerWithoutBrackets(incomingExpression);
            return answer;
        }

        /// <summary>
        /// Вычисляет выражение, представленное в формате string,
        /// без пробелов, без скобок и без знака "=" в конце.
        /// </summary>
        /// <param name="incomingExpression">Выражение</param>
        /// <returns>Ответ (тип double)</returns>
        public static double GetAnswerWithoutBrackets(string incomingExpression)
        {
            string[] expressionInArray = ParserStringExpression(incomingExpression);
            int amountMultAndDiv = GetNumberMultAndDiv(expressionInArray);
            int amountSumAndSub = GetNumberSumAndSub(expressionInArray); ;
            int amountOfAllOperators = amountMultAndDiv + amountSumAndSub;

            for (int i = 0; i < amountOfAllOperators; i++)
            {
                int numberReplace = 0;
                double result = 0;
                bool rewriteArray = false;
                if (i < amountMultAndDiv)
                {
                    for (int j = 0; j < expressionInArray.Length; j++)
                    {
                        if (expressionInArray[j] == "*")
                        {
                            result = double.Parse(expressionInArray[j - 1]) *
                                double.Parse(expressionInArray[j + 1]);
                            numberReplace = j - 1;
                            rewriteArray = true;
                            break;
                        }
                        if (expressionInArray[j] == "/")
                        {
                            result = double.Parse(expressionInArray[j - 1]) /
                                double.Parse(expressionInArray[j + 1]);
                            numberReplace = j - 1;
                            rewriteArray = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < expressionInArray.Length; j++)
                    {
                        if (expressionInArray[j] == "+")
                        {
                            result = double.Parse(expressionInArray[j - 1]) +
                                double.Parse(expressionInArray[j + 1]);
                            numberReplace = j - 1;
                            rewriteArray = true;
                            break;
                        }
                        if (expressionInArray[j] == "-")
                        {
                            result = double.Parse(expressionInArray[j - 1]) -
                                double.Parse(expressionInArray[j + 1]);
                            numberReplace = j - 1;
                            rewriteArray = true;
                            break;
                        }
                    }
                }
                // Если какая-либо операция была произведена, 
                // то переписываем и сокращаем массив.
                if (rewriteArray)
                {
                    expressionInArray[numberReplace] = Convert.ToString(result);
                    for (int k = numberReplace + 1; k < expressionInArray.Length - 2; k++)
                    {
                        expressionInArray[k] = expressionInArray[k + 2];
                    }
                    // Сдвинули массив, теперь обрезаем его.
                    Array.Resize(ref expressionInArray, expressionInArray.Length - 2);
                    //rewriteArray = false;
                }
            }
            return double.Parse(expressionInArray[0]); ;
        }

        // Метод парсит выражение из строки в массив типа string[].
        static string[] ParserStringExpression(string incomingExpression)
        {
            string[] operands = incomingExpression.Split(new char[] { '-', '+', '*', '/' },
            StringSplitOptions.RemoveEmptyEntries);
            string[] operators = incomingExpression.Split(new char[]
                { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' , ','},
                StringSplitOptions.RemoveEmptyEntries);

            // Если первый элемент строки минус, то первый операнд делаем отрицательным,
            // сдвигаем массив операторов влево на одну позицию и обрезаем последний элемент.
            if (incomingExpression[0] == '-')
            {
                operands[0] = Convert.ToString(double.Parse(operands[0]) * (-1));
                for (int i = 0; i < operators.Length - 1; i++)
                {
                    operators[i] = operators[i + 1];
                }
                Array.Resize(ref operators, operators.Length - 1);
            }

            // Если в массиве операторов находится элемент с более, чем одним символом
            // и второй символ - минус, то делаем соответствующую ячейку массива
            // операндов отрицательной
            for (int i = 0; i < operators.Length; i++)
            {
                if (operators[i].Length > 1 && operators[i][1] == '-')
                {
                    operands[i + 1] = Convert.ToString(double.Parse(operands[i + 1]) * (-1));
                    operators[i] = Convert.ToString(operators[i][0]);
                }
            }

            // Конечный массив,в котором будет разбитая строчка.
            string[] expressionInArray = new string[operands.Length + operators.Length];

            // Заполнение конечного массива expressionInArray[] по порядку.
            int d = 0;
            // ЗАМЕЧАНИЕ: цикл в любом случае записывает в первый элемент массива число,
            // даже если было просто "-2" - станет { 2 ; - }
            for (int i = 0, j = 1, k = 0; i < expressionInArray.Length; i += 2, j += 2, k++)
            {
                expressionInArray[i] = operands[k];
                if (d < operators.Length) expressionInArray[j] = operators[k];
                d++;
            }
            return expressionInArray;
        }

        // Метод, возвращающий количество операторов умножения и деления.
        static int GetNumberMultAndDiv(string[] expressionInArray)
        {
            int count = 0;
            for (int i = 0; i < expressionInArray.Length; i++)
            {
                if (expressionInArray[i] == "*" || expressionInArray[i] == "/")
                    count++;
            }
            return count;
        }

        // Метод, возвращающий количество операторов сложения и вычитания.
        static int GetNumberSumAndSub(string[] expressionInArray)
        {
            int count = 0;
            for (int i = 0; i < expressionInArray.Length; i++)
            {
                if (expressionInArray[i] == "+" || expressionInArray[i] == "-")
                    count++;
            }
            return count;
        }

        // Метод считает и возвращает массив с позициями "(" в строке.
        static int[] PositionsOpeningBrackets(string incomingExpression)
        {
            int[] array = new int[0];
            for (int i = 0; i < incomingExpression.Length; i++)
            {
                if (incomingExpression[i] == '(')
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = i;
                }
            }
            return array;
        }

        // Метод считает и возвращает сколько символов ")" в строке.
        int CounterClosingBrackets(string incomingExpression)
        {
            int count = 0;
            for (int i = 0; i < incomingExpression.Length; i++)
            {
                if (incomingExpression[i] == ')')
                    count++;
            }
            return count;
        }
    }
}
