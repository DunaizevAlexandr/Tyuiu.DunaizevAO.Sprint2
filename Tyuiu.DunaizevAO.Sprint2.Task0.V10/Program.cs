using Tyuiu.DunaizevAO.Sprint2.Task0.V10.Lib;

DataService ds = new DataService();

int x = 1305;
int y = 475;
bool[] result = new bool[6];
result = ds.GetCompareOperations(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
