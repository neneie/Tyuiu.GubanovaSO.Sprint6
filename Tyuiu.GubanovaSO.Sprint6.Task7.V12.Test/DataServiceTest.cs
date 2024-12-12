using Tyuiu.GubanovaSO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task7.V12.Test
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
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask7V12.csv";

            int[,] res = ds.GetMatrix(path);

            int[,] wait = {
               {17, 17, -7, -19, -4, 6, 4, -17, 0, 13},
               {-13, -13, -7, -15, -12, -1, 15, 18, 0, -19},
               {9, -12, -9, 8, -12, 20, 10, -6, 0, -1},
               {-15, -19, 19, 16, -15, -19, 8, -2, 0,-18},
               {-14, -9, -19, 20, -3, 8, -10, 4, 0, 12},
               {-18,-4,-14,20,-20,17,-18,-19,0,6},
               {17,14,1,-18,0,2,-3,-9,0,-13},
               {-14,-10,-15,19,12,-18,6,15,0,-16},
               {19,18,14,5,8,4,-13,10,0,20},
               {-7,3,12,7,-1,-13,-6,3,0,-8}
                                                      };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}