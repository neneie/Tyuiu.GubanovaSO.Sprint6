using Tyuiu.GubanovaSO.Sprint6.Task5.V17.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task5.V17.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Sonya\source\repos\Tyuiu.GubanovaSO.Sprint6\Tyuiu.GubanovaSO.Sprint6.Task5.V17\bin\Debug\InPutDataFileTask5V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}