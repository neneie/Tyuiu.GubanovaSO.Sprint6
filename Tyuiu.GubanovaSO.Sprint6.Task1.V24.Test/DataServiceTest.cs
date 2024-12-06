using Tyuiu.GubanovaSO.Sprint6.Task1.V24.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task1.V24.Test
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

            double[] res = ds.GetMassFunction(0, 9);
            double[] wait = { -6, -7.85, -2.43, 5.91, 4.33, -11.82, -29.08, -27.03, -1.24, 26.84 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}