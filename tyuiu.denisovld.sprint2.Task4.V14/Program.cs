using tyuiu.denisovld.sprint2.Task4.V14.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Тернарный оператор                                                                      *");
Console.WriteLine("* Задание #4                                                                                    *");
Console.WriteLine("* Вариант #14                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием тернарного          *");
Console.WriteLine("* оператора, где пользователь вводит значение переменных х,у с клавиатуры.                      *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

double x;
double y;

Console.WriteLine("Введите значение х");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение у");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

Console.WriteLine("Значение функции = " + ds.Calculate(x,y));
Console.ReadKey();