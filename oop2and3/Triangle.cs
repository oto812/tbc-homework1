namespace homework1.oop2and3;

public class Triangle : Shape
{ 
    public Point P1 { get ;}
    public Point P2 { get;}
    public Point P3 { get;}

    public Triangle(Point p1, Point p2, Point p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;

        if (Area() == 0)
            throw new ArgumentException("Points do not form a valid triangle.");
    }
    
    public override double Area()
    {
        double side1 = Point.Distance(P1, P2);
        double side2 = Point.Distance(P1, P3);
        double side3 = Point.Distance(P2, P3);
        double s = (side1 + side2 + side3) / 2;
        
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3) );
    }

    public override double Perimeter()
    {
        double side1 = Point.Distance(P1, P2);
        double side2 = Point.Distance(P1, P3);
        double side3 = Point.Distance(P2, P3);
        return side1 + side2 + side3;
    }
    
}