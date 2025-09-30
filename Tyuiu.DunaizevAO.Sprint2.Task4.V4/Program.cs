using Tyuiu.DunaizevAO.Sprint2.Task4.V4.Lib;

DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите x: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите y: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.Calculate(x, y);
Console.WriteLine(res);