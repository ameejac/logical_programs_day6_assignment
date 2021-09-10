namespace coupon_prblm.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int[] coupon = new int [10];
            int n = 10;
            bool is_dup = false;
            Random random = new Random();
            //computation
            for (int i = 0; i < n; i++)
            {
               
                int new_coupon = random.Next(100000, 900000);
               // Console.WriteLine("Coupan is:" +i + new_coupan);
                for(int j = 0; j < i; j++)
                {
                    if(coupon[i] == new_coupon)
                    {
                        Console.WriteLine("got the duplicate coupan");
                        is_dup = true;
                        break;
                    }
                    
                }
                if (is_dup == false)
                {
                    coupon[i] = new_coupon;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(coupon[i]);
            }
        }
    }
}

