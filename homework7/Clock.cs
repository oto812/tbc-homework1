namespace homework1.homework7;

public class Clock
{
   private int hour;
   private int minute;
   private int second;
   
   public int Hour { get => hour;
      set
      {
         if (value >= 0 && value < 24)
         {
            hour = value;
         }
         else
         {
            Console.WriteLine("Hour must be between 0 and 24");
         }
      } 
   }

   public int Minute
   {
      get => minute;
      set
      {
         if (value >= 0 && value < 60)
         {
            minute = value;
         }
         else
         {
            Console.WriteLine("Minute must be between 0 and 60");
         }
      }
   }

   public int Second
   {
      get => second;
      set
      {
         if (value >= 0 && value < 60)
         {
            second = value;
         }
         else
         {
            Console.WriteLine("Second must be between 0 and 60");
         }
      }
   }

   public void AddSecond()
   {
      second = (second + 1) % 60;
      if (second == 0)
      {
        AddMinute();
      }
      
   }
   public void AddMinute()
   {
      minute = (minute + 1) % 60;
      if (minute == 0)
      {
         AddHour();
      }
      
   }
   public void AddHour()
   {
      hour = (hour + 1) % 24;
   }

   public void SubtractSecond()
   {
      second = second == 0 ? second - 1 : 59;
      if (second == 59)
      {
         SubtractMinute();
      }
   }

   public void SubtractMinute()
   {
      minute = minute == 0 ? minute - 1 : 59;
      if (minute == 59)
      {
         SubtractHour();
      }
   }

   public void SubtractHour()
   {
      hour = hour == 0 ? hour - 1 : 59;
      
   }

   public void GetCurrentTime()
   {
      string hours = hour < 10 ? $"0{hour}" : hour.ToString();
      string minutes = minute < 10 ? $"0{minute}" : minute.ToString();
      string seconds = second < 10 ? $"0{second}" : second.ToString();
      Console.WriteLine($"{hours}:{minutes}:{seconds}");
   }

   public static void main()
   {
      Console.Write("Enter hours: ");
      int hour = int.Parse(Console.ReadLine());
      Console.Write("Enter minutes: ");
      int minute = int.Parse(Console.ReadLine());
      Console.Write("Enter seconds: ");
      int second = int.Parse(Console.ReadLine());
      Clock clock = new Clock();
      clock.hour = hour;
      clock.Minute = minute;
      clock.Second = second;
      clock.AddSecond();
      clock.AddSecond();
      clock.AddSecond();
      clock.AddSecond();
      Console.WriteLine("after 4 AddSecond() method");
      clock.GetCurrentTime();
      clock.AddSecond();
      clock.AddSecond();
      clock.AddSecond();
      clock.AddMinute();
      Console.WriteLine("after 3 AddSecond() method and 1 AddMinute() method");
      clock.GetCurrentTime();


   }
}
