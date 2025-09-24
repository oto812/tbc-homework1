namespace homework1.homework3;

public class Task3
{
   public static void Main()
   {
      Console.Write("Enter a number: ");
      int input = Convert.ToInt32(Console.ReadLine());

      for (int i = 1; i <= input; i++)
      {
         Console.WriteLine(i + " cubed is " + Math.Pow(i,3));
      }
   }
}