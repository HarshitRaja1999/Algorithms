using System;
namespace Maths
{
     class BinaryExponentiation
     {
         static int binExp(int a , int n)
         {
             int b;
             if(n == 0)
             {
                 return 1;
             }
             else if ( n%2 == 1)
             {
                 return binExp(a , n-1 ) * a;
             }
             else
             {
                 b = binExp(a , n / 2);
                 return b*b;
             }
         }
         public void Run()
         {
             int a , n;
             Console.Write("Enter the Base :\t");
             a = int.Parse(Console.ReadLine());

             Console.Write("Enter the power :\t");
             n = int.Parse(Console.ReadLine());

             Console.WriteLine("The Answer is :\t" + binExp( a , n ));
         }
     }
}