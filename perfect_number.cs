using System;
public class perfect_num
{
    public static void Main()
    {
        //variables
        int n, i, sum;
        int a, b;
        //computation
        //Console.Write("\n\n");
        //Console.Write("Find perfect numbers within a given number of range:\n");
        //Console.Write("enter the numbers");
        //Console.Write("\n\n");

        Console.Write("Input the starting range or number : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write(" print The all Perfect numbers within the given range : ");
        for (n = a; n <= b; n++)
        {
            i = 1;
           sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }

                i++;
            }
            if (sum == n)
                Console.Write("perfer number is:{0} \n", n);

        }
        Console.Write("\n");
    }
}

