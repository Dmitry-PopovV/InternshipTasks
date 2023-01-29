internal abstract class Figure
{
    protected string _type;

    public string type
    {
        get
        {
            return _type;
        }
    }

    public abstract double area(params double[] par);

    public abstract bool checkParam(params double[] par);
}