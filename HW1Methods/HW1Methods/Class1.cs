using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Methods
{
    public static class HomeworkVariables
    {
        public static (int, int ) PrintTheResultOfTheDivisionToTheConsole(int NumberA, int NumberB)
        {        
            if (NumberB == 0)
            {
                throw new Exception("NumberB != 0");
            }         
                return (NumberA / NumberB, NumberA % NumberB);
        }

        public static double GetsolutionOfTheEquation(double A, double B)
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
            if (VariableB == VariableA)
            {
                throw new Exception("В не может быть равным А");
            }
            string C;
            C = VariableA;
            VariableA = VariableB;
            VariableB = C;
        }

        public static double PrintЕheЫolutionЕoЕheСonsole(double oneNumber, double twoNumber, double thirdNumber)
        {
            if (oneNumber == 0)
            {
                throw new Exception("oneNumber не может быть равным 0");
            }
            double x = (((thirdNumber - twoNumber) / oneNumber));
            return x;
        }
        public static string StraightLineEquation(int X1, int Y1, int X2, int Y2)
        {
            if (X1== X2)
            {
                throw new Exception("");
            }
            if (Y1 == Y2)
            {
                throw new Exception("");
            }

            double tmp1 = Y1 - Y2;
            double tmp2 = X2 - X1;
            double tmp3 = X1 * Y2 - X2 * Y1;

            double a = tmp1 / tmp2;
            double b = tmp3 / tmp2;
            string result = "y=" + a + "*x" + b;
            return result;
        }

    }
}
