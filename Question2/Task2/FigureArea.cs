namespace Task2
{
    public static class FigureArea
    {
        static FigureArea()
        {
            dict = new Dictionary<string, Figure>();
            addFigure(new Circle());
            addFigure(new Triangle());
        }

        public static double calc(string type, params double[] par)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (par == null)
                throw new ArgumentNullException("par");

            ref Dictionary<string, Figure> dict = ref FigureArea.getDict();

            try
            {
                return dict[type].area(par);
            }
            catch(KeyNotFoundException)
            {
                throw new ArgumentException(String.Format("Figure type \"{0}\" not found", type));
            }
        }



        private static Dictionary<string, Figure> dict;

        internal static ref Dictionary<string, Figure> getDict()
        {
            return ref dict;
        }

        internal static void addFigure(Figure f)
        {
            dict.Add(f.ToString(), f);
        }

    }
}
