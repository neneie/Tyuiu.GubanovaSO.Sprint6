using Tyuiu.GubanovaSO.Sprint6.Task6.V18.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task6.V18.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V18.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB";
            Assert.AreEqual(wait, res);
        }
    }
    
}