namespace homework1.oop2and3;

public class Main
{
    public static void main()
    {
        Shape[] shapes = { TriangleInput(), RectangleInput(), CircleInput() };
        foreach (Shape shape in shapes)
        {
            if(shape is Triangle)
            { 
                Console.WriteLine($"Area of triangle: {shape.Area()}");
                Console.WriteLine($"Perimeter of triangle: {shape.Perimeter()}");
            }else if (shape is Rectangle)
            {
                Console.WriteLine($"Area of rectangle: {shape.Area()}");
                Console.WriteLine($"Perimeter of rectangle: {shape.Perimeter()}");
            }else if (shape is Circle)
            {
                Console.WriteLine($"Area of circle: {shape.Area()}");
                Console.WriteLine($"Perimeter of circle: {shape.Perimeter()}");
            }
        }
    }


    public static Triangle TriangleInput()
    {
        Console.WriteLine("Enter X coordinate of Triangles first point : ");
        double triangle1X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Triangles firsrt point :");
        double triangle1Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of Triangles second point : ");
        double triangle2X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Triangles second point : ");
        double triangle2Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of Triangles third point : ");
        double triangle3X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Triangles third point : ");
        double triangle3Y = Convert.ToDouble(Console.ReadLine());
        
        Point p1 = new Point(triangle1X, triangle1Y);
        Point p2 = new Point(triangle2X, triangle2Y);
        Point p3 = new Point(triangle3X, triangle3Y);
        Triangle triangle = new Triangle(p1, p2, p3);
        return triangle;
        
    }

    public static Rectangle RectangleInput()
    {
        Console.WriteLine("Enter X coordinate of Rectangles first point : ");
        double rectangle1X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Rectangles first point : ");
        double rectangle1Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of Rectangles second point : ");
        double rectangle2X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Rectangles second point : ");
        double rectangle2Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of Rectangles third point : ");
        double rectangle3X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Rectangles third point : ");
        double rectangle3Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of Rectangles fourth point : ");
        double rectangle4X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of Rectangles fourth point : ");
        double rectangle4Y = Convert.ToDouble(Console.ReadLine());
        
        Point p1 = new Point(rectangle1X, rectangle1Y);
        Point p2 = new Point(rectangle2X, rectangle2Y);
        Point p3 = new Point(rectangle3X, rectangle3Y);
        Point p4 = new Point(rectangle4X, rectangle4Y);
        
        Rectangle rectangle = new Rectangle(p1, p2, p3, p4);
        return rectangle;
    }

    public static Circle CircleInput()
    {
        Console.WriteLine("Enter X coordinate of circles center : ");
        double circle1X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of circles center : ");
        double circle1Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter X coordinate of circles another point : ");
        double circle2X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate of circles another point : ");
        double circle2Y = Convert.ToDouble(Console.ReadLine());
        
        Point p1 = new Point(circle1X, circle1Y);
        Point p2 = new Point(circle2X, circle2Y);
        
        Circle circle = new Circle(p1, p2);
        return circle;
    }
    
    
}