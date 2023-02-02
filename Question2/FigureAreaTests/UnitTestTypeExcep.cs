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
            double res = FigureArea.calc(type, par);

        }

        [TestMethod]
        [DataRow("a", 1)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFindTypeWrongExcep(string type, double par)
        {
            double res = FigureArea.calc(type, par);

        }
    }
}