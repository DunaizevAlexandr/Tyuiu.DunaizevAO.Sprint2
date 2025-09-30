using Tyuiu.DunaizevAO.Sprint2.Task1.V5.Lib;

DataService ds = new DataService();
int a = 154;
int b = 163;
int c = 134;
int d = 137;

bool[] result = new bool[6];
result = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);
Console.WriteLine("D = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
