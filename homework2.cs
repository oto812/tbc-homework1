namespace homework1;

public class homework2
{
    public static void Main()
    {
        // Task 1
        Console.WriteLine("Enter Integer Number");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(input % 2 == 0
            ? $"Entered number "+ input + " is even."
            : $"Entered number "+ input +  " is odd.");
        
        // Task 2
        Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1)
        {
            Console.WriteLine("this can't be a triangle!");
        }
        else
        {
            Console.WriteLine("this should be a triangle!");
        }
        //Task 3
        Console.WriteLine("Enter Integer Number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The pow of entered number is " + Math.Pow(num,2));
        
        //Task 4
        Console.WriteLine("Enter your birth year");
        int year = Convert.ToInt32(Console.ReadLine());

        switch ((year - 1924) % 12)
        {
            case 0:  Console.WriteLine(year + " was dragon year"); break;
            case 1:  Console.WriteLine(year + " was Ox year");  break;
            case 2:  Console.WriteLine(year + " was Tiger year");  break;
            case 3:  Console.WriteLine(year + " was Rabbit year");  break;
            case 4:  Console.WriteLine(year + " was Dragon year");  break;
            case 5:  Console.WriteLine(year + " was Snake year");  break;
            case 6:  Console.WriteLine(year + " was Horse year");  break;
            case 7:  Console.WriteLine(year + " was Goat year");  break;
            case 8:  Console.WriteLine(year + " was Monkey year");  break;
            case 9:  Console.WriteLine(year + " was Rooster year");  break;
            case 11: Console.WriteLine(year + " was Pig year"); break;
            default: Console.WriteLine("this won't be printed"); break; 
            
        }
        
        //Task 5
        
        Console.WriteLine("Enter your day of birth");
        int day = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter your month  of birth ");
        string month = Convert.ToString(Console.ReadLine());
        
        string zodiac = "";
        
        switch (month)
        {
            case "January":
                zodiac = (day <= 19) ? "Capricorn" : "Aquarius";
                break;
            case "February":
                zodiac = (day <= 18) ? "Aquarius" : "Pisces";
                break;
            case "March":
                zodiac = (day <= 20) ? "Pisces" : "Aries";
                break;
            case "April":
                zodiac = (day <= 19) ? "Aries" : "Taurus";
                break;
            case "May":
                zodiac = (day <= 20) ? "Taurus" : "Gemini";
                break;
            case "June":
                zodiac = (day <= 20) ? "Gemini" : "Cancer";
                break;
            case "July":
                zodiac = (day <= 22) ? "Cancer" : "Leo";
                break;
            case "August":
                zodiac = (day <= 22) ? "Leo" : "Virgo";
                break;
            case "September":
                zodiac = (day <= 22) ? "Virgo" : "Libra";
                break;
            case "October":
                zodiac = (day <= 22) ? "Libra" : "Scorpio";
                break;
            case "November":
                zodiac = (day <= 21) ? "Scorpio" : "Sagittarius";
                break;
            case "December":
                zodiac = (day <= 21) ? "Sagittarius" : "Capricorn";
                break;
            default:
                Console.WriteLine("Invalid month!");
                break;
            
        }
        Console.WriteLine(day + " " + month + " is " + zodiac);


    }
    
}

