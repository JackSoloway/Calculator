using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpellingChecker
{
    public class CorrectSpellingExpressionChecker
    {
        static public bool SpellingIsCorrect(string incommingExpression)
        {
            // Возвращает true, если написание выражения корректно.
            bool equally;
            equally = OpAndClBracketIsEqual(incommingExpression);

            if (equally)
            {
                string errorCondition = @"\(\+|\(\*|\(\/|\d\(|\(\)|,\(|\(,|\($|" +
                                      @"\)\(|-\)|\+\)|\*\)|/\)|\)\d|,\)|\),|^\)|" +
                                      @"-$|--|-\+|-\*|-/|-,|,-|" +
                                      @"^\+|\+$|\+\+|\+-|\+\*|\+/|\+,|,\+|" +
                                      @"^\*|\*$|\*\*|\*-|\*\+|\*/|\*,|,\*|" +
                                      @"^/|/$|//|/-|/\+|/\*|/,|,/|" +
                                      @",,|^,|,$|,\d*?,";
                Regex regex = new Regex(errorCondition);
                Match match = regex.Match(incommingExpression);
                return !match.Success;
            }
            else
                return false;
        }

        static private bool OpAndClBracketIsEqual (string incommingExpression)
        {
            // Возвращает true, если количество открывающих и скобок равно.
            int opBracketCounter = 0, clBracketCounter = 0;
            for (int i = 0; i < incommingExpression.Length; i++)
            {
                if (incommingExpression[i] == '(')
                    opBracketCounter++;
                if (incommingExpression[i] == ')')
                    clBracketCounter++;
            }
            return opBracketCounter == clBracketCounter;
        }
    }
}
