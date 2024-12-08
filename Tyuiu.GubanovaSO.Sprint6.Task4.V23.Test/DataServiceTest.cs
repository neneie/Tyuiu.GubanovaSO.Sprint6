using Tyuiu.GubanovaSO.Sprint6.Task4.V23.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task4.V23.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int startValue = -1;
            int stopValue = 1;
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] expected = new double[3];
            expected[0] = 5.36;
            expected[1] = 2.5;
            expected[2] = 0;

            CollectionAssert.AreEqual(expected, res);
        }
    }
}