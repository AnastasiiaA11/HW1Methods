
using HW1Methods;

Console.WriteLine("Введите первое число.");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int B = Convert.ToInt32(Console.ReadLine());

double r =HomeworkVariablesSecond.solutionOfTheEquation( A, B);
Console.WriteLine(r);


Console.WriteLine("Введите первое число.");
int oneNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int twoNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

double add = HomeworkVariablesFourth.solutionOfaLinearEquation(oneNumber, twoNumber, thirdNumber);
Console.WriteLine(add);


Console.WriteLine("Введите первое число.");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число.");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число.");
int Y2 = Convert.ToInt32(Console.ReadLine());

string an=HomeworkVariablesFive.straightLineEquation(X1,Y1,X2,Y2);
Console.WriteLine(an);


