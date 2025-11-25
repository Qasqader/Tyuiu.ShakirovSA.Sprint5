using Tyuiu.ShakirovSA.Sprint5.Task7.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V25.txt";
        string pathsave = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V25.txt");
        Console.WriteLine("Хранятся входники " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        pathsave = ds.LoadDataAndSave(path);
        Console.WriteLine("Ответ = " + pathsave);
        Console.WriteLine();
        Console.ReadKey();
    }
}