using HW1Methods;

Console.WriteLine("Первое задание.Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.");
Console.WriteLine("Введите первое число А.");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число В.");
int NumberB = Convert.ToInt32(Console.ReadLine());
double ahh = HomeworkVariables.PrintTheResultOfTheDivisionToTheConsole((int)NumberA, (int)NumberB);
Console.WriteLine(ahh);


Console.WriteLine("Второе задание. Пользователь вводит 2 числа (A и B). Выведите в консоль решение.");
Console.WriteLine("Введите первое число.");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int B = Convert.ToInt32(Console.ReadLine());
double r = HomeworkVariables.GetsolutionOfTheEquation(A, B);
Console.WriteLine(r);

Console.WriteLine("Третье задание. Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте содержимое переменных A и B местами");
Console.WriteLine("Введите первое значение А.");
string VariableA = Console.ReadLine();
Console.WriteLine("Введите второе значение В.");
string VariableB = Console.ReadLine();
string C = "";

HomeworkVariables.SwapTheContentsOfTheVariables(ref VariableB, ref VariableA);
Console.WriteLine(VariableB, VariableA);



Console.WriteLine("Четвертое задание.Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.");
Console.WriteLine("Введите первое число не равное 0.");
int oneNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число не равное 0.");
int twoNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число число не равное 0.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

double add = HomeworkVariables.ЗrintЕheЫolutionЕoЕheСonsole(oneNumber, twoNumber, thirdNumber);
Console.WriteLine(add);


Console.WriteLine("Пятое задание.Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.");
Console.WriteLine("Введите первое число Х1.");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число Y1.");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число X2.");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число Y2.");
int Y2 = Convert.ToInt32(Console.ReadLine());

string an = HomeworkVariables.straightLineEquation(X1, Y1, X2, Y2);
Console.WriteLine(an);



