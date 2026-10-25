using tyuiu.denisovld.sprint2.Task7.V3.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
Console.WriteLine("* X,Y в заштрихованной области.                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
double y;

Console.WriteLine("Введите X");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res;
if (ds.CheckDotInShadedArea(x,y))
{
    res = $"Точка с координатами x = {x} y = {y} находится в закрашенной области.";
}

else
    res = $"Точка с координатами x = {x} y = {y} не находится в закрашенной области.";

Console.WriteLine(res);
Console.ReadKey();