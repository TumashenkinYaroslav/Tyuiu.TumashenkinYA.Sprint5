using Tyuiu.TumashenkinYA.Sprint5.Task6.V4.Lib;

DataService ds = new DataService();
Console.WriteLine("* УСЛОВИЕ:              );                                                  *");
Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл)      *");
Console.WriteLine("* в котором есть набор символьных данных. Найти количество заглавных      *");
Console.WriteLine("* русских букв в заданной строке.                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V4.txt");


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine("Ответ " + res);



Console.ReadKey();