using Tyuiu.TumashenkinYA.Sprint5.Task1.V16.Lib;
DataService ds = new DataService();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано функция, произвести табулирование на заданном диапазоне [-5,5] с   *");
Console.WriteLine("* шагом 1. Произвести проверку на ноль. При делении на ноль вернуть ноль  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int start = -5;
int end = 5;


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(start, end);
Console.WriteLine("Файл: " + res);

Console.WriteLine("Создан!");



Console.ReadKey();
