using tyuiu.denisovld.sprint2.Task3.V19.Lib;

Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 2 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #2                                                                                     *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                                           *");
Console.WriteLine("* Задание #3                                                                                    *");
Console.WriteLine("* Вариант #19                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием           *");
Console.WriteLine("* вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры.       *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

double x;
Console.WriteLine("Введите значение х");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

Console.WriteLine("Значение y = " + ds.Calculate(x));

Console.ReadKey();