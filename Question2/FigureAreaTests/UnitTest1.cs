using Task2;

namespace FigureAreaTest
{
    [TestClass]
    public class UnitTestTypeExcep
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindTypeNullExcep()
        {
            string type = null;
            double[] par = { 1 };

            double res = FigureArea.find(type, par);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTypeWrongExcep()
        {
            string type = "a";
            double[] par = { 1 };

            double res = FigureArea.find(type, par);

        }
    }

    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestFindCircleRight()
        {
            string type = "circle";
            double[][] par = { new double[] { 0 }, new double[] { 1 }, new double[] { 2 } };
            double[] resolts = { 0, 3.1415926535897932384626433832795, 12.566370614359172953850573533118 };
            for (int i = 0; i < par.Length; i++)
            {
                double res = FigureArea.find(type, par[i]);
                Assert.AreEqual(resolts[i], res);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindCircleExcep1()
        {
            string type = "circle";
            double[] par = null;

            double res = FigureArea.find(type, par);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindCircleExcep2()
        {
            string type = "circle";
            double[][] par = { new double[] { }, new double[] { 1, 1 } };

            for (int i = 0; i < par.Length; i++)
            {
                double res = FigureArea.find(type, par[i]);
            }
        }
    }

    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestFindTriangleRight()
        {
            string type = "triangle";
            double[][] par = { new double[] { 0, 0, 0 }, new double[] { 1, 1, 1 }, new double[] { 3, 2, 3 } };
            double[] resolts = { 0, 0.43301270189221932338, 2.8284271247461903 };
            for (int i = 0; i < par.Length; i++)
            {
                double res = FigureArea.find(type, par[i]);
                Assert.AreEqual(resolts[i], res);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindTriangleExcep1()
        {
            string type = "triangle";
            double[] par = null;

            double res = FigureArea.find(type, par);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTriangleExcep2()
        {
            string type = "triangle";
            double[][] par = { new double[] { 1, 2, 3 }, new double[] { }, new double[] { 1, 1 }, new double[] { 1, 1, 1, 1 } };

            for (int i = 0; i < par.Length; i++)
            {
                double res = FigureArea.find(type, par[i]);
            }
        }
    }
}