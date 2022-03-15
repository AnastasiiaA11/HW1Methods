using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Methods
{
    public static class HomeworkVariables
    {
        public static double PrintTheResultOfTheDivisionToTheConsole(int NumberA, int NumberB)
        {
            double answerDivision = 0;
            double answerRemainder = 0;

            if (NumberB == 0)
            {
                throw new Exception("NumberB != 0");
            }

            if (NumberB > 0 || NumberB < 0 && NumberA > 0 || NumberA < 0)
            {
                answerDivision = (NumberA / NumberB);
                answerRemainder = NumberA % NumberB;
            }
            return answerRemainder;
        }

        public static double GetsolutionOfTheEquation(int A, int B)
        {
            if (B == A)
            {
                throw new Exception("В не может быть равным А");
            }
            double x = ((5 * A) + (B * B)) / (B - A);
            return x;

        }

        public static void SwapTheContentsOfTheVariables(ref string VariableA, ref string VariableB)
        {
            string C;
            C = VariableA;
            VariableA = VariableB;
            VariableB = C;
        }

        public static double ЗrintЕheЫolutionЕoЕheСonsole(int oneNumber, int twoNumber, int thirdNumber)
        {
            if (oneNumber == 0)
            {
                throw new Exception("oneNumber не может быть равным 0");
            }
            double x = (((thirdNumber - twoNumber) / oneNumber));
            return x;
        }
        public static string straightLineEquation(int X1, int Y1, int X2, int Y2)
        {
            double tmp1 = Y1 - Y2;
            double tmp2 = X2 - X1;
            double tmp3 = X1 * Y2 - X2 * Y1;

            double a = tmp1 / tmp2;
            double b = tmp3 / tmp2;
            string result = "y=" + a + "*x+" + b;
            return result;
        }

    }
}
