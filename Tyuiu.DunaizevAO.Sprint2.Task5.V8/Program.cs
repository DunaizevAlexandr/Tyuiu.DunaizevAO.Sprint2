using Tyuiu.DunaizevAO.Sprint2.Task5.V8.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.FindDateOfPreviousDay(m, n);
Console.WriteLine(res);