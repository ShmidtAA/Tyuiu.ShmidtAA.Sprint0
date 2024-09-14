using Tyuiu.ShmidtAA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.ShmidtAA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Additional(5, 5));
        }
        [TestMethod]

        public void CheckedSubtractValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]

        public void CheckedDivision()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}