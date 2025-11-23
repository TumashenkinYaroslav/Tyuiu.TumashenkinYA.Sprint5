using Tyuiu.TumashenkinYA.Sprint5.Task0.V9.Lib;

int x = 3;

DataService ds = new DataService();
Console.Write("x = " + x);//
Console.WriteLine();
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();