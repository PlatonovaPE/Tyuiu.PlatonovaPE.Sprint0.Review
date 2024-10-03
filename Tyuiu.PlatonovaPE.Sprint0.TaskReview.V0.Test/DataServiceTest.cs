using Tyuiu.PlatonovaPE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PlatonovaPE.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {

            DataService ds = new DataService();
            int x = 6;
            int y = 4;
            int z = 5;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(75, res);

            
        }
    }
}