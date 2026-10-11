using tyuiu.denisovld.sprint2.Task2.V1.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                                            *");
Console.WriteLine("* Задание #2                                                                                    *");
Console.WriteLine("* Вариант #1                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет            *");
Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                               *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int x;
int y;

Console.WriteLine("Введите значение х");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение у");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

if (ds.CheckDotInShadedArea(x, y) == true)
{
    Console.WriteLine("Точка с координатами x = " + x + " и y = " + y + " принадлежит закрашенной области.");
}
else
{
    Console.WriteLine("Точка с координатами x = " + x + " и y = " + y + " не принадлежит закрашенной области.");
}