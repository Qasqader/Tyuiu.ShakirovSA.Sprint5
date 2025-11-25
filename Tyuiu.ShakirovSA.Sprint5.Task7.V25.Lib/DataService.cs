using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakirovSA.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V25.txt");
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSave);
            }
            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'H') && (line[i] != 'e') && (line[i] != 'l') && (line[i] != 'o') && (line[i] != 'I') && (line[i] != 's') && (line[i] != 'M') && (line[i] != 'y') && (line[i] != 'F') && (line[i] != 'i') && (line[i] != 'r') && (line[i] != 's') && (line[i] != 't') && (line[i] != 'P') && (line[i] != 'g') && (line[i] != 'a') && (line[i] != 'm'))
                        {
                            strline = strline + line[i];
                        }
                    }
                }
                strline = System.Text.RegularExpressions.Regex.Replace(strline, @"\s+([.,!?;:])", "$1");
                strline = System.Text.RegularExpressions.Regex.Replace(strline, @"\s+", " ");
                strline = strline.Trim();
                File.AppendAllText(pathSave, strline + Environment.NewLine);

                return pathSave;
            }
        }
    }
}
