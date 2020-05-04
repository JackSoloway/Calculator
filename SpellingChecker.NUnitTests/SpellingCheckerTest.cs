using NUnit.Framework;

namespace SpellingChecker.NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Open Brackets.
        [TestCase("3+(+4*2)", false)]
        [TestCase("3+(-5*2)", true)]
        [TestCase("2-(*7/1)+9", false)]
        [TestCase("1/(/9*7)-2", false)]
        [TestCase("4(2+2)", false)]
        [TestCase("3+()-2", false)]
        [TestCase("0+5,(7*7)", false)]
        [TestCase("(,01-2)/7", false)]
        [TestCase("(7-1)-(", false)]

        // Close Brackets.
        [TestCase("(2+3)(3-7)", false)]
        [TestCase("(4/3-)+2", false)]
        [TestCase("(4/8+)-9", false)]
        [TestCase("(6*2*)+3", false)]
        [TestCase("(2+2/)", false)]
        [TestCase("(2+2)4", false)]
        [TestCase("(7-5,)-5", false)]
        [TestCase("(4/2),6+2", false)]
        [TestCase(")-2+3", false)]
        [TestCase("((7*7))+3", true)]

        // Minus.
        [TestCase("2--2", false)]
        [TestCase("3-+6", false)]
        [TestCase("7-*9", false)]
        [TestCase("8-/8", false)]
        [TestCase("5-,5", false)]
        [TestCase("4,-3", false)]

        // Plus.
        [TestCase("2++2", false)]
        [TestCase("3+-6", false)]
        [TestCase("7+*9", false)]
        [TestCase("8+/8", false)]
        [TestCase("5+,5", false)]
        [TestCase("4,+3", false)]

        // Multiply
        [TestCase("2**2", false)]
        [TestCase("3*+6", false)]
        [TestCase("7*-9", false)]
        [TestCase("8*/8", false)]
        [TestCase("5*,5", false)]
        [TestCase("4,*3", false)]

        // Divide.
        [TestCase("2//2", false)]
        [TestCase("3/+6", false)]
        [TestCase("7/*9", false)]
        [TestCase("8/-8", false)]
        [TestCase("5/,5", false)]
        [TestCase("4,/3", false)]

        // Coma.
        [TestCase("2,,2+3", false)]
        [TestCase(",3+2", false)]
        [TestCase("7-9,", false)]
        [TestCase("8,01,2-8", false)]

        // Correct examples.
        [TestCase("(27+2,02)*2,095949-7/((3-8)+5)", true)]
        [TestCase("4-(0,6/2)+9", true)]



        public void TestCases(string input, bool expectedResult)
        {
            Assert.AreEqual(expectedResult,
                CorrectSpellingExpressionChecker.SpellingIsCorrect(input));
        }

            //Assert.Pass();
        
    }
}