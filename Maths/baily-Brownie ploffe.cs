using System;
namespace Maths
{
    class Brownie_Ploffe
    {
        static double brownie(int n)
        {
            double pi = ((16 ^ -n) * (4.0 / (8.0 * (double)n + 1.0) - 2 / (8.0 * (double)n + 4.0) - 1 / (8.0 * (double)n + 5.0) - 1.0 / (8.0 * (double)n + 6.0)));
            return(pi);
        }
        public void Run()
        {
            double sum = 0;

            Console.Write("Enter The Value :\t");
            var t = Convert.ToInt32(Console.Read());

            for (int i = 1; i < t+1; i++)
            {
                sum += brownie(i);
                Console.WriteLine(sum.ToString());
            }
            Console.ReadLine();
        }
    }
}