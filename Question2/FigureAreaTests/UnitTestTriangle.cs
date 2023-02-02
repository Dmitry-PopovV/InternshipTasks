using Task2;

namespace FigureAreaTest
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        [DataRow("Triangle", new double[] { 0, 0, 0 }, 0)]
        [DataRow("Triangle", new double[] { 1, 1, 1 }, 0.43301270189221932338)]
        [DataRow("Triangle", new double[] { 3, 2, 3 }, 2.8284271247461903)]
        public void TestFindTriangleRight(string type, double[] par, double resolt)
        {
            double res = FigureArea.calc(type, par);
            Assert.AreEqual(resolt, res);
        }

        [TestMethod]
        [DataRow("Triangle", null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindTriangleExcep1(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { 1, 2, 3 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep2(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep3(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { 1, 1 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep4(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { 1, 1, 1, 1 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep5(string type, double[] par)
        {
            double res = FigureArea.calc(type, par);
        }
    }
}