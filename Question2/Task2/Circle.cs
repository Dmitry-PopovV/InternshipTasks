internal class Circle : Figure
{
    public override bool checkParam(params double[] par)
    {
        if (par.Length != 1)
        {
            throw new ArgumentException("Invalid parameters number");
        }
        else
        {
            return true;
        }
    }

    public override double area(params double[] r)
    {
        checkParam(r);
        if (r[0] < 0)
            throw new ArgumentException();
        return Math.Pow(r[0], 2) * Math.PI;
    }
}