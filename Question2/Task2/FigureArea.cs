namespace Task2
{
    public static class FigureArea
    {
        public static double find(string type, params double[] par)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (par == null)
                throw new ArgumentNullException("par");

            ref List<Figure> list = ref FigureList.getList();

            foreach (Figure i in list)
            {
                if (i.type == type)
                {
                    if (par.Length != i.argCount)
                    {
                        throw new ArgumentException("Invalid parameters number");
                    }
                    return i.area(par);
                }
            }
            throw new ArgumentException(String.Format("Figure type \"{0}\" not found", type));
        }

    }
    internal abstract class Figure
    {
        protected string _type;

        protected int _argCount;

        public string type
        {
            get
            {
                return _type;
            }
        }

        public int argCount
        {
            get
            {
                return _argCount;
            }
        }

        public abstract double area(params double[] par);
    }

    internal static class FigureList
    {
        static FigureList()
        {
            list = new List<Figure>
            {
                new Circle(),
                new Triangle()
            };
        }

        private static List<Figure> list;

        public static ref List<Figure> getList()
        {
            return ref list;
        }

    }

    internal class Circle : Figure
    {
        public Circle()
        {
            _type = "circle";
            _argCount = 1;
        }

        public override double area(params double[] r)
        {
            if (r[0] < 0)
                throw new ArgumentException();
            return Math.Pow(r[0], 2) * Math.PI;
        }
    }

    internal class Triangle : Figure
    {
        public Triangle()
        {
            _type = "triangle";
            _argCount = 3;
        }

        public override double area(params double[] sides)
        {
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            double intermRes = p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]);
            if (((intermRes <= 0) && (sides[0] != 0) && (sides[1] != 0) && (sides[2] != 0)) || (sides[0] < 0) || (sides[1] < 0) || (sides[2] < 0))
                throw new ArgumentException("Imposible triangle");
            return Math.Pow(intermRes, 0.5);
        }
    }
}