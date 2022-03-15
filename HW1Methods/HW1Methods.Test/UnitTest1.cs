using NUnit.Framework;
using System;

namespace HW1Methods.Test
{
    public class HomeworkVariablesTest
    {
        [TestCase(10, 2, 5)]
        [TestCase(17, 5, 3)]
        [TestCase(0, 4, 0)]
        [TestCase(-10, 2, -5)]
        public void PrintTheResultOfTheDivisionToTheConsoleTest(int NumberA, int NumberB, int expected)
        {
            double actual = HomeworkVariables.PrintTheResultOfTheDivisionToTheConsole(NumberA, NumberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 0)]
        [TestCase(0, 0)]
        [TestCase(0, 4)]
        [TestCase(-2, 0)]
        public void PrintTheResultOfTheDivisionToTheConsoleTest_WhenValuesAreZeroShouldExeption(int NumberA, int NumberB)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.PrintTheResultOfTheDivisionToTheConsole(NumberA, NumberB));
        }


    }
}