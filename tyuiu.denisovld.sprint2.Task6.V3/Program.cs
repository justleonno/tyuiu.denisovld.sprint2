
using tyuiu.denisovld.sprint2.Task6.V3.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Получение результата из switch                                                          *");
Console.WriteLine("* Задание #6                                                                                    *");
Console.WriteLine("* Вариант #3                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch вычисляет    *");
Console.WriteLine("* требуемое значение и возвращает результат. Условие: Составить программу, которая в зависимости*");
Console.WriteLine("* от порядкового номера дня недели (1, 2, …, 7) выводит на экран его название                   *");
Console.WriteLine("* (понедельник, вторник, …, воскресенье).                                                       *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int g;

Console.WriteLine("Введите число дня");
g = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

string res;
if ((g > 7) | (g < 1))
{
    res = "Введенно неверное значение!";
}

else
    res = ds.FindDayName(g);

Console.WriteLine("День недели - " + res);
Console.ReadKey();