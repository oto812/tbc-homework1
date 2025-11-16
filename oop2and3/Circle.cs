namespace homework1.oop2and3;

public class Circle : Shape
{
    public Point Center { get; set; }
    public Point AnotherPoint { get; set; }

    public Circle(Point center, Point anotherPoint)
    {
        Center = center;
        AnotherPoint = anotherPoint;
    }

    public override double Area()
    {
        double radius = Point.Distance(Center, AnotherPoint);

        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        double radius = Point.Distance(Center, AnotherPoint);
        return 2 * Math.PI * radius;
    }
    
}