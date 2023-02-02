using Task2;

namespace FigureAreaTest
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        [DataRow("Circle", 0, 0)]
        [DataRow("Circle", 1, 3.1415926535897932384626433832795)]
        [DataRow("Circle", 2, 12.566370614359172953850573533118)]
        public void TestFindCircleRight(string type, double par, double resolt)
        {
            double res = FigureArea.calc(type, par);
            Assert.AreEqual(resolt, res, 0.0001);
        }

        [TestMethod]
        [DataRow("Circle", null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindCircleExcep1(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);

        }

        [TestMethod]
        [DataRow("Circle", new double[] { })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindCircleExcep2(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);

        }

        [TestMethod]
        [DataRow("Circle", new double[] { 1, 1 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindCircleExcep3(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);

        }
    }
}