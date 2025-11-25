using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakirovSA.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    foreach (string numberStr in numbers)
                    {
                        double number = Convert.ToDouble(numberStr, CultureInfo.InvariantCulture);
                        if (number % 1 != 0)
                        {
                            res *= number;
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
