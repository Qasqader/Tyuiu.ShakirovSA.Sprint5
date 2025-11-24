using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakirovSA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = Convert.ToDouble(str, CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Cos(x) + Math.Pow(x, 2) - ((2 * x) / 1.2), 3);
            return res;
        }
        
    }
}
