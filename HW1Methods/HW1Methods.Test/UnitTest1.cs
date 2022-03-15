using NUnit.Framework;
using System;

namespace HW1Methods.Test
{
    public class HomeworkVariablesTest
    {
        [TestCase(10, 2, 5,0)]
        [TestCase(17, 5, 3,2)]
        [TestCase(0, 4, 0,0)]
        [TestCase(-10, 2, -5,0)]
        public void PrintTheResultOfTheDivisionToTheConsoleTest(int NumberA, int NumberB, int expected, int expected2)
        {
            (int,int) result = HomeworkVariables.PrintTheResultOfTheDivisionToTheConsole(NumberA, NumberB);
            int actual = result.Item1;
            int actualTwo = result.Item2;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actualTwo);
        }      
        [TestCase(4, 0)]
        [TestCase(-2, 0)]
        public void PrintTheResultOfTheDivisionToTheConsoleTest_WhenValuesAreZeroShouldExeption(int NumberA, int NumberB)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.PrintTheResultOfTheDivisionToTheConsole(NumberA, NumberB));
        }

        [TestCase(4, 10, 20)]
        [TestCase(1,4,7)]
        [TestCase(18,20,245)]
        public void GetsolutionOfTheEquationTest(double A, double B, double expected)
        {
            double actual = HomeworkVariables.GetsolutionOfTheEquation(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(-5, -5)]
        [TestCase(0, 0)]
        public void GetsolutionOfTheEquationTest_WhenAEqualsBShouldExeption(int A, int B)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.GetsolutionOfTheEquation(A, B));
        }

        [TestCase("more","run","run","more")]
        [TestCase("ocean","sun","sun","ocean")]
        [TestCase("pop","it","it","pop")]
        [TestCase("arctic","monkeys","monkeys","arctic")]
        public void SwapTheContentsOfTheVariablesTest(string VariableA, string VariableB, string expected, string expectedTwo)
        {
            HomeworkVariables.SwapTheContentsOfTheVariables(ref VariableA, ref VariableB);
            Assert.AreEqual(expected, VariableA);
            Assert.AreEqual(expectedTwo, VariableB);
        }

        [TestCase("run","run")]
        [TestCase("sun","sun")]
        public void SwapTheContentsOfTheVariablesTest_WhenAEqualsBShouldExeption(string VariableA, string VariableB)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.SwapTheContentsOfTheVariables(ref VariableA, ref VariableB));
        }

        [TestCase(7,6,9,0.4)]
        [TestCase(5,1,1,0.2)]
        [TestCase(10,2,5,0.3)]
        [TestCase(-8,2,26,-3)]
        public void Print≈he€olution≈o≈he—onsoleTest(double oneNumber, double twoNumber, double thirdNumber, double expected)
        {
            double actual = HomeworkVariables.Print≈he€olution≈o≈he—onsole(oneNumber,twoNumber,thirdNumber);
            Assert.AreEqual(expected, actual);
            
        }
        [TestCase(0,4,4)]
        [TestCase(0,8,4)]
        [TestCase(0,4,-5)]
        public void Print≈he€olution≈o≈he—onsoleTest_WhenTheEnteredNumberIs(double oneNumber, double twoNumber, double thirdNumber)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.Print≈he€olution≈o≈he—onsole(oneNumber, twoNumber, thirdNumber));
        }
        [TestCase(1,3,5,7,"y=-1*x-2")]
        [TestCase(9,10,5,13,"y=0,75*x-16,75")]
        [TestCase(13,4,8,10,"y=1,2*x-19,6")]
        [TestCase(-5,-1,5,-9, "y=0,8*x5")]
        public void StraightLineEquationTest(int X1, int Y1, int X2, int Y2, string expected)
        {
            string actual = HomeworkVariables.StraightLineEquation(X1,Y1,X2,Y2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,2,1,5)]
        [TestCase(5,8,5,1)]
        [TestCase(10,1,10,11)]
        public void StraightLineEquationTest_ThenX1EqualsX2(int X1, int Y1, int X2, int Y2)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.StraightLineEquation(X1, Y1, X2, Y2));
        }
        [TestCase(1, 2, 8, 2)]
        [TestCase(5, 8, 3, 8)]
        [TestCase(10, 1, 11, 1)]
        public void StraightLineEquationTest_ThenY1EqualsY2(int X1, int Y1, int X2, int Y2)
        {
            Assert.Throws<Exception>(() => HomeworkVariables.StraightLineEquation(X1, Y1, X2, Y2));
        }
    }

}