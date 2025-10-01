using Tyuiu.DunaizevAO.Sprint2.Task7.V9.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите X: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

bool res = ds.CheckDotInShadedArea(x, y);
if (res ==  true)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области");
}