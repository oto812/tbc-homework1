namespace homework1.oop2and3;

public static class IntExtensions
{
    public static bool IsOdd(this int value)
    {
        return value % 2 != 0;
    }

    public static int Abs(this int value)
    {
        return value < 0 ? -value : value;
    }

    public static int RoundToNearestMultiple(this int value, int multiple)
    {
        int remainder = value % multiple;
        if (remainder == 0)
        {
            return value;
        }else if (remainder >= multiple / 2)
        {
            return value + remainder;
        }
        else
        {
            return value - multiple + remainder;
        }
    }
    
}