using Tyuiu.ShakirovSA.Sprint5.Task7.V25.Lib;
namespace Tyuiu.ShakirovSA.Sprint5.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V25.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}
