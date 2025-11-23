using Tyuiu.ShakirovSA.Sprint5.Task1.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int start = -5;
        int stop = 5;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("start = " + start);
        Console.WriteLine("stop = " + stop);
        Console.WriteLine("Исходный массив");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(start, stop);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан");
        Console.WriteLine();
        Console.ReadKey();
    }
}