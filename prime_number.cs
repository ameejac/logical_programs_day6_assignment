using System;

namespace prime_num_prblm.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int num;
            int i;
            bool Flag= false;
            Console.WriteLine("please enter the number");
            num = int.Parse(Console.ReadLine());
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Flag = true;
                    Console.WriteLine(i);
                }
            }
            if( Flag == false)
            {
                Console.WriteLine("its a prime numbers:" + num);
            } else
            {
                Console.WriteLine("its not a prime numbers:" + num);
            }
            
        
        }
    }
}

