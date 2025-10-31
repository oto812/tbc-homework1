namespace homework1.dataStructures;

public class Tuples
{
    public static void main()
    {
        Console.WriteLine(PointCalculations((1,2,3),(4,6,8)));
    }

    public static double PointCalculations((double,double, double) t1, (double,double,double) t2)
    {
        return Math.Sqrt(Math.Pow(t2.Item1-t1.Item1, 2) + Math.Pow(t2.Item2-t1.Item2, 2) + Math.Pow(t2.Item3-t1.Item3, 2));
    }
}