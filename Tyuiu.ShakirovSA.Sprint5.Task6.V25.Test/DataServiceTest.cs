using Tyuiu.ShakirovSA.Sprint5.Task6.V25.Lib;
namespace Tyuiu.ShakirovSA.Sprint5.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask6V25.txt");
            Assert.AreEqual(6, res);
        }
    }
}
