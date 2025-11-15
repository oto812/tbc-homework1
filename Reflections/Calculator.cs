using System.Reflection;

namespace homework1.Reflections;

public static class Calculator
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }

    public static double Pow(int num, int pow)
    {
        return Math.Pow(num, pow);
    }

    public static void main()
    {

        Type type = typeof(Calculator);
        MethodInfo[] mInfos = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);
        foreach (var mInfo in mInfos)
        {
            if (mInfo.Name != "main")
            {
                Console.Write($"Method Name : {mInfo.Name} - Parameters : ");
                foreach (var parameterInfo in mInfo.GetParameters())
                {
                    Console.Write($"{parameterInfo.ParameterType} {parameterInfo.Name} ,");
                }
                Console.WriteLine();
            }


        }
        Console.Write("Enter the Name of the Method you want to use : ");
        string methodName = Console.ReadLine();
        bool found = false;

        foreach (var mInfo in mInfos)
        {
            if (mInfo.Name == methodName)
            {
                found = true;
                object[] parameters = new object[mInfo.GetParameters().Length]; { };
                int i = 0;
                foreach (var parameterInfo in mInfo.GetParameters())
                {
                    Console.Write($"Enter {parameterInfo.Name} : ");
                    try
                    {
                        object param = Convert.ChangeType(Console.ReadLine(), parameterInfo.ParameterType);
                        parameters[i] = param;
                        i++;
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"your input parameter is not convertable to {parameterInfo.ParameterType}");
                        return;
                    }
                }
                Console.WriteLine($"Result :  {mInfo.Invoke(null,parameters)}");
            }
        }

        if (!found)
        {
            Console.WriteLine("Method not found");
        }
        
    }
}