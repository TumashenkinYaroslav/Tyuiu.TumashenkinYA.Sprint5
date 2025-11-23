using Tyuiu.TumashenkinYA.Sprint5.Task5.V18.Lib;
Console.WriteLine("* УСЛОВИЕ:                                                                *");

Console.WriteLine("*                                                                         *");

Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V18.txt";

Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

var result = ds.LoadFromDataFile(path);
Console.WriteLine(result);
Console.ReadKey();  