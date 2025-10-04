namespace homework1.homework7;

public class Triangle
{
    private int side1;
    private int side2;
    private int side3;
    
    private bool checkSides(int s1, int s2, int s3)
    {
        if (s1 > 0 && s2 > 0 && s3 > 0)
        {
            if (s1 + s2 > s3 && s2 + s3 <= s1 && s3 + s1 <= s2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("It is not valid triangle");
                return false;
            }
        }

        return true;

    }
    
    public int Side1
    {
        get
        {
            return side1;
        }
        set
        {

            if (checkSides(value, side2, side3))
            {
                side1 = value;
            }
        }
    }
    public int Side2
    {
        get
        {
            return side2;
        }
        set
        {

            if (checkSides(side1, value, side3))
            {
                side2 = value;
            }
        }
    }
    public int Side3
    {
        get
        {
            return side3;
        }
        set
        {

            if (checkSides(side1, side2, value))
            {
                side3 = value;
            }
            
        }
    }
    public void Area()
    {
        if (side1 == 0 || side2 == 0 || side3 == 0)
        {
            return;
        }
        double s = (side1 + side2 + side3) / 2;
        
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        Console.WriteLine($"Area of the triangle is: {area}");
    }

    public void Perimeter()
    {
        if (side1 == 0 || side2 == 0 || side3 == 0)
        {
            return;
        }
        Console.WriteLine($"Perimeter of the triangle is: {side1 + side2 + side3}");
    }

    public static void main()
    {
        Console.Write("Enter side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());
        Triangle triangle = new Triangle();
        triangle.Side1 = side1;
        triangle.Side2 = side2;
        triangle.Side3 = side3;
        triangle.Perimeter();
        triangle.Area();
       
        
    }
}