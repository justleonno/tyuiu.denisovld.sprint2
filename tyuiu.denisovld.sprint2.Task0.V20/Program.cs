using tyuiu.denisovld.sprint2.Task0.V20.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Операции сравнения                                                                      *");
Console.WriteLine("* Задание #0                                                                                    *");
Console.WriteLine("* Вариант #20                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций   *");
Console.WriteLine("* не должна нарушаться) и арифметических выражений, которая вернет логическую                   *");
Console.WriteLine("* последовательность(массив): (True,False,True,False,True,False), при x = 1075, y = 275         *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int x = 1075;
int y = 275;
Console.WriteLine("Значение x = " + x);
Console.WriteLine("Значение y = " + y);
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();

