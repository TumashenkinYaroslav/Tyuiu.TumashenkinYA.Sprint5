using Tyuiu.TumashenkinYA.Sprint5.Task3.V13.Lib;
int x = 3;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение y(x) = x / x^3 + 2, вычислить его значение при x = 3,    *");
Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на    *");
Console.WriteLine("* консоль. Округлить до трёх знаков после запятой.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("x = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан.");
Console.ReadKey();