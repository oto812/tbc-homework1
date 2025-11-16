namespace homework1.oop2and3;

public class Rectangle : Shape
{
    /*
    assume that points are given accordingly: P1 - bottom left , P2 - top left,
    p3 - top right, p4 - top left
    */
    public Point P1 { get; }
    public Point P2 { get; }
    public Point P3 { get; }
    public Point P4 { get; }

    public Rectangle(Point p1, Point p2, Point p3, Point p4)
    {
        if (IsValidRectangle(p1, p2, p3, p4))
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }
        else
        {
            throw new ArgumentException("Invalid rectangle");
        }
    }

    private bool IsValidRectangle(Point p1, Point p2, Point p3, Point p4)
    {
        bool verticalSides = p1.X == p2.X && p3.X == p4.X;
        bool horizontalSides = p2.Y == p3.Y && p1.Y == p4.Y;
        bool nonZeroArea = (p2.Y > p1.Y) && (p3.X > p2.X);

        return verticalSides && horizontalSides && nonZeroArea;
    }
    

    public override double Area()
    {
      
        double side1 = Point.Distance(P1, P2);
        double side2 = Point.Distance(P2, P3);
        return side1 * side2;
    }

    public override double Perimeter()
    {
        double side1 = Point.Distance(P1, P2);
        double side2 = Point.Distance(P2, P3);
        double side3 = Point.Distance(P3, P4);
        double side4 = Point.Distance(P4, P1);
        return side1 + side2 + side3 + side4;
    }
}