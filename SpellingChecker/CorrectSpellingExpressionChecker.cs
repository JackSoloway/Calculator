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
        static public bool CheckCorrectSpellingExpression(string incommingExpression)
        {
            string errorCondition = @"\(\+|\(\-|\(\*|\(\/|\d\(|\(\)|,\(|\(,|\($|
                                      \)\(|-\)|\+\)|\*\)|/\)|\)\d|,\)|\),|^\)|
                                      --|-\+|-\*|-/|-,|,-|
                                      \+\+|\+-|\+\*|\+/|\+,|,\+|
                                      \*\*|\*-|\*\+|\*/|\*,|,\*|
                                      //|/-|/\+|/\*|/,|,/|
                                      ,,|^,|,$|,\d*?,";
            Regex regex = new Regex(errorCondition);
            Match match = regex.Match(incommingExpression);
            return match.Success;
        }
    }
}
