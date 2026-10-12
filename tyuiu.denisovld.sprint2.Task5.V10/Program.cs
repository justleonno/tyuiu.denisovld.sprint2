using tyuiu.denisovld.sprint2.Task5.V10.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Оператор switch                                                                         *");
Console.WriteLine("* Задание #5                                                                                    *");
Console.WriteLine("* Вариант #10                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и         *");
Console.WriteLine("* возвращает результат. Условие: Дата некоторого дня характеризуется тремя натуральными         *");
Console.WriteLine("* числами: g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m               *");
Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным.                         *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int g;
int m;
int n;

Console.WriteLine("Введите год");
g = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день");
n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

string res;
if ((m > 12) | (m < 1))
{
    res = "Введенно неверное значение!";
}
else if ((n > 31) | (n < 1))
{
    res = "Введенно неверное значение!";
}
else
     res = ds.FindDateOfPreviousDay(g, m, n);
Console.WriteLine("Дата предыдущего дня - " + res );
Console.ReadKey();