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
            incommingExpression = incommingExpression.Insert(position, symbol);
            return incommingExpression;
        }

        public static string DelFromExpression(string incommingExpression, int position)
        {
            incommingExpression = incommingExpression.Remove(position - 1, 1);
            return incommingExpression;
        }    
    }
}
