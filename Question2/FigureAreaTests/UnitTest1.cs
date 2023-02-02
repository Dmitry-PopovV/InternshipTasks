using Task2;

namespace FigureAreaTest
{
    [TestClass]
    public class UnitTestTypeExcep
    {
        [TestMethod]
        [DataRow(null, 1)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindTypeNullExcep(string type, double par)
        {
            //string type = null;
            //double[] par = { 1 };

            double res = FigureArea.calc(type, par);

        }

        [TestMethod]
        [DataRow("a", 1)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTypeWrongExcep(string type, double par)
        {
            //string type = "a";
            //double[] par = { 1 };

            double res = FigureArea.calc(type, par);

        }
    }

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
            Assert.AreEqual(resolt, res);
        }

        [TestMethod]
        [DataRow("Circle", null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindCircleExcep1(string type, double[] par)
        {
            //string type = "Circle";
            //double[] par = null;

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

    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        [DataRow("Triangle", new double[] { 0, 0, 0 }, 0)]
        [DataRow("Triangle", new double[] { 1, 1, 1 }, 0.43301270189221932338)]
        [DataRow("Triangle", new double[] { 3, 2, 3 }, 2.8284271247461903)]
        public void TestFindTriangleRight(string type, double[] par, double resolt)
        {
            /*string type = "Triangle";
            double[][] par = { new double[] { 0, 0, 0 }, new double[] { 1, 1, 1 }, new double[] { 3, 2, 3 } };
            double[] resolts = { 0, 0.43301270189221932338, 2.8284271247461903 };
            for (int i = 0; i < par.Length; i++)
            {*/
                double res = FigureArea.calc(type, par);
                Assert.AreEqual(resolt, res);
            //}
        }

        [TestMethod]
        [DataRow("Triangle", null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindTriangleExcep1(string type, double[] par)
        {
            //string type = "Triangle";
            //double[] par = null;

            double res = FigureArea.calc(type, par);

        }

        [TestMethod]
        [DataRow("Triangle", new double[] { 1, 2, 3 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep2(string type, double[] par)
        {
            /*string type = "Triangle";
            double[][] par = { new double[] { 1, 2, 3 }, new double[] { }, new double[] { 1, 1 }, new double[] { 1, 1, 1, 1 } };

            for (int i = 0; i < par.Length; i++)
            {*/
                double res = FigureArea.calc(type, par);
            //}
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep3(string type, double[] par)
        {
            /*string type = "Triangle";
            double[][] par = { new double[] { 1, 2, 3 }, new double[] { }, new double[] { 1, 1 }, new double[] { 1, 1, 1, 1 } };

            for (int i = 0; i < par.Length; i++)
            {*/
            double res = FigureArea.calc(type, par);
            //}
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { 1, 1 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep4(string type, double[] par)
        {
            /*string type = "Triangle";
            double[][] par = { new double[] { 1, 2, 3 }, new double[] { }, new double[] { 1, 1 }, new double[] { 1, 1, 1, 1 } };

            for (int i = 0; i < par.Length; i++)
            {*/
            double res = FigureArea.calc(type, par);
            //}
        }

        [TestMethod]
        [DataRow("Triangle", new double[] { 1, 1, 1, 1 })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep5(string type, double[] par)
        {
            /*string type = "Triangle";
            double[][] par = { new double[] { 1, 2, 3 }, new double[] { }, new double[] { 1, 1 }, new double[] { 1, 1, 1, 1 } };

            for (int i = 0; i < par.Length; i++)
            {*/
            double res = FigureArea.calc(type, par);
            //}
        }
    }
}