using Tyuiu.TumashenkinYA.Sprint5.Task6.V4.Lib;
namespace Tyuiu.TumashenkinYA.Sprint5.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V4.txt");
            DataService ds = new DataService();

            int wait = 0;
            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}
