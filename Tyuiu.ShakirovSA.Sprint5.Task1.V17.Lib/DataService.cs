using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakirovSA.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            if (fileexists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(2 * i - 4 + ((2 * i - 1) / (Math.Sin(i) + 1)), 2);
                stry = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
