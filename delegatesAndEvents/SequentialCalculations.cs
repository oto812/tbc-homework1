namespace homework1.delegates_events;

public class SequentialCalculations
{
    public delegate decimal MathOperations(decimal num1, decimal num2);

    public static decimal Add(decimal num1, decimal num2)
    {
        Console.WriteLine($"Adding {num1} and {num2} to the sequential calculations. result : {num1 + num2}");
        return num1 + num2;
    }

    public static decimal Subtract(decimal num1, decimal num2)
    {
        Console.WriteLine($"Subtracting {num1} and {num2} to the sequential calculations. result : {num1 - num2}");
        return num1 - num2;
    }

    public static decimal Multiply(decimal num1, decimal num2)
    {
        Console.WriteLine($"Multiplying {num1} and {num2} to the sequential calculations. result : {num1 * num2}");
        return num1 * num2;
    }

    public static decimal Divide(decimal num1, decimal num2)
    {
        Console.WriteLine($"Dividing {num1} and {num2} to the sequential calculations. result : {num1 / num2}");
        return num1 / num2;
    }

    public static void Main()
    {
        MathOperations mathOperations1 = Add;
        mathOperations1 += Subtract;
        mathOperations1 += Multiply;
        
        MathOperations mathOperations2 = Divide;
        mathOperations2 += Multiply;
        mathOperations2 += Subtract;
        
        MathOperations mathOperations3 = Multiply;
        mathOperations3 += Add;
        mathOperations3 += Subtract;

        mathOperations1(1, 2);
        mathOperations2(2, 3);
        mathOperations3(3, 4);
    }
}