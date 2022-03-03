using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Methods
{
    static class HomeworkVariablesSecond
    {

        public static double solutionOfTheEquation(int A, int B)
        {
            double x = ((((5 * A) + (B * B)) / (B - A)));
            return x;
        }
    }

    static class HomeworkVariablesFourth
    {

        public static double solutionOfaLinearEquation(int oneNumber, int twoNumber, int thirdNumber)
        {
            double x=(((thirdNumber - twoNumber) / oneNumber));
            return x;
        }
    }

    static class HomeworkVariablesFive
    {
        public static string straightLineEquation(int X1, int Y1, int X2, int Y2)
        {
            double tmp1 = Y1 - Y2;
            double tmp2 = X2 - X1;
            double tmp3 = X1 * Y2 - X2 * Y1;

            double a = tmp1 / tmp2;
            double b = tmp3 / tmp2;
            string result="y="+a+"*x+"+b;
            return result;
        }

    }
}
