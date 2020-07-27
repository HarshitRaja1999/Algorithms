using System;
namespace Maths
{
    class BinExpMod
    {
        static int bin_exp_mod(int a , int n , int b)
        {
            int s = 0;
            if(b != 0)
            {
                if(n==0)
                {
                    return 1;
                }

                if(n % 2 == 1)
                {
                    return (bin_exp_mod(a , n-1 , b) * a ) % b;
                }

                s = bin_exp_mod(a , n/2 , b);
                return ( s * s ) % b;
            }
            else
            {
                throw new Exception("zero not accepted...!");
            }
            
        }

        public void Run()
        {
            int a , n , b;
            Console.Write("Enter Base :\t");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the Power :\t");
            n = int.Parse(Console.ReadLine());

            Console.Write("ENter the Modulo :\t");
            b = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("The Answer is :\t" + bin_exp_mod(a , n , b));
            }
            catch
            {
                bin_exp_mod( a , n , b );
            }

        }
    }
}