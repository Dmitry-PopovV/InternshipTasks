internal class Triangle : Figure
{
    public Triangle()
    {
        _type = "triangle";
    }

    public override bool checkParam(params double[] par)
    {
        if (par.Length != 3)
        {
            throw new ArgumentException("Invalid parameters number");
        }
        else
        {
            return true;
        }
    }

    public override double area(params double[] sides)
    {
        checkParam(sides);
        double p = (sides[0] + sides[1] + sides[2]) / 2;
        double intermRes = p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]);
        if (((intermRes <= 0) && (sides[0] != 0) && (sides[1] != 0) && (sides[2] != 0)) || (sides[0] < 0) || (sides[1] < 0) || (sides[2] < 0))
            throw new ArgumentException("Imposible triangle");
        return Math.Pow(intermRes, 0.5);
    }
}