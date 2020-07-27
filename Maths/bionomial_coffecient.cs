using System;
using System.Linq;
using System.Collections.Generic;

namespace Maths
{
    class BionomialCoff
    {
        static void BioCoff(int n , int r)        
        {
            List<int> c = Enumerable.Repeat(0, r+1).ToList();
            c[0] = 1;
            for (int i = 1; i <=n ; i++)`
            {
                int j;
                j = Math.Min( i , r );
                while (j > 0)
                {
                    c[j] += c[j-1];
                    j -= 1;
                }
            }
            Console.Write("The Answer is :\t" + c[r]);
        }

        public void Run()
        {
            int n , r;
            Console.Write("Enter the Value of N :\t");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter the Value of R :\t");
            r = int.Parse(Console.ReadLine());

            BioCoff( n , r );
        }
    }
}