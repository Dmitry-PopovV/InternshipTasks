namespace Task2
{
    public static class FigureArea
    {
        static FigureArea()
        {
            list = new List<Figure>
            {
                new Circle(),
                new Triangle()
            };
        }

        public static double calc(string type, params double[] par)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (par == null)
                throw new ArgumentNullException("par");

            ref List<Figure> list = ref FigureArea.getList();

            foreach (Figure i in list)
            {
                if (i.type == type)
                {
                    return i.area(par);
                }
            }
            throw new ArgumentException(String.Format("Figure type \"{0}\" not found", type));
        }

        

        private static List<Figure> list;

        internal static ref List<Figure> getList()
        {
            return ref list;
        }

    }
}
