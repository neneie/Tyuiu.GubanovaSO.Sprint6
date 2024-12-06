using Tyuiu.GubanovaSO.Sprint6.Task0.V20.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task0.V20.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(9.037, ds.Calculate(3));
        }
    }
}