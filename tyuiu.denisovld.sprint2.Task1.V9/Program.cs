using tyuiu.denisovld.sprint2.Task1.V9.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Логические операции                                                                     *");
Console.WriteLine("* Задание #1                                                                                    *");
Console.WriteLine("* Вариант #9                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно      *");
Console.WriteLine("* чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,  *");
Console.WriteLine("* последовательность операций не должна нарушаться), а также арифметических выражений, которая  *");
Console.WriteLine("* вернет логическую последовательность(массив): (False, False, True, False, True, False),       *");  
Console.WriteLine("* при a = 15, b = 335, c = 174, d = 478                                                         *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int a = 15;
int b = 335;
int c = 174;
int d = 478;
Console.WriteLine("Значение a = " + a);
Console.WriteLine("Значение b = " + b);
Console.WriteLine("Значение c = " + c);
Console.WriteLine("Значение d = " + d);

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();
