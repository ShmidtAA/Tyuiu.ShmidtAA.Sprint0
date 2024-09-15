using Tyuiu.ShmidtAA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.ShmidtAA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15,res);

        }
        [TestMethod]
        public void CheckSubtractionValid()
        {
            var numbers = new int[] {1,2,3,4,5 };
            var res = DataService.SubtractionArray( numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultiplicationValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);

        }
    }
}