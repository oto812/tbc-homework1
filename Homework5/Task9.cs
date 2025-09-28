using System.Runtime.CompilerServices;

namespace homework1.Homework5;

public class Task9
{
    public static void main()
    {
        product(1, 2, 3, 4);
        productRec(1, 2, 3, 4);

    }

    public static int product(params int[] nums)
    {
        int product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        Console.WriteLine($"the product of array elements is: {product}");
        return product;

    }

    public static int productRec(params int[] nums)
    {
        int product = helper(0, nums);
        Console.WriteLine($"the product of array elements is: {product}");
        return product;
    }

    public static int helper(int curIndex, params int[] nums)
    {
        if (curIndex >= nums.Length)
        {
            return 1;
        }
        else
        {
            return nums[curIndex] * helper(++curIndex, nums);
        } 
        
    }
}