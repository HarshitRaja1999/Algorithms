using System;
using System.Collections.Generic;
using System.Linq;
namespace Maths
{
    class BasicMaths
    {
        static List<int>primeFactors(int n)
        {
            var pf = new List<int>();
            while (n % 2 == 0)
            {
                pf.Add(2);
                n = n / 2;
            }
            for(int i = 3 ; i <= Math.Sqrt(n) ; i+=2)
            {
                while (n%i==0)
                {
                    pf.Add(i);
                    n= n / i;
                }
            }
            if(n>2)
            {
                pf.Add(n);
            }
            return pf;
        }

        static void numberOfDivisors(int n)
        {
            int div = 1,temp=1;
            while (n%2==0)
            {
                temp+=1;
                n=n/2;
            }
            div *= temp;
            for(int i=3 ; i < Math.Sqrt(n)+1 ; i += 2)
            {
                temp=1;
                while (n%i==0)
                {
                    temp+=1;
                    n=n/i;
                }
                div *= temp;
            }
            Console.WriteLine("Answer is :\t"+div);
        }   

        static void sumOfDivisor(int n)
        {
            double s=1.0,temp =1;
            while ( n % 2 == 0)
            {
                temp += 1;
                n = n / 2;
            }
            if(temp > 1)
            {
                s *= (Math.Pow(2.0 , (double)temp) - 1) / ( 2 - 1 );
            }
            for(int i = 3 ; i <= Math.Sqrt(n) ; i+=2)
            {
                temp = 1;
                while ( n % i == 0)
                {
                    temp += 1;
                    n = n / i;
                }
                if(temp > 1)
                {
                    s *= (Math.Pow((double)i , (double)temp) - 1) / ( i - 1 );
                }
            }
            Console.Write("The Answer is :\t" + s);
        }
        static void eularPhi(int n)
        {
            float s = n;
            if(s == 0 )
                s = 1;
            var snewPf = new List<int>();

            snewPf.AddRange(primeFactors(n).Distinct());
            snewPf.ForEach(x => {
                s *= (((float)x- (float)1.00) / (float)x);                
            });
            Console.WriteLine("Answer is :\t" + s);
        }

        public void Run()
        {       
            string ch1,ch2;
            int number;
            do
            {
                Console.WriteLine("1. Prime_Factor , 2. Number_of_Divisor , 3.Eular_Phi , 4.Sum_of_Divisor :\n");
                Console.Write("Enter Your Choice :\t");
                int n = int.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Enter the Value :\t");
                    number = int.Parse(Console.ReadLine());
                    switch(n)
                    {
                        case 1 : 
                            // primeFactors(number);
                            {
                                var nf = primeFactors(number);
                                Console.Write("{");
                                foreach(int i in nf)
                                {
                                    Console.Write(i + ", ");
                                }
                                Console.Write("}\n");
                            }
                            break;
                        case 2 :
                            numberOfDivisors(number);
                            break;
                        case 3 :
                            eularPhi(number);
                            break;
                        case 4 :
                            sumOfDivisor(number);
                            break;
                        default :
                            Console.WriteLine("Enter Correct Choice...!\n");
                            break;
                    }
                    Console.Write("\nDo you Want to Enter the Value Again/(y/n) :\t");
                    ch1 = Console.ReadLine();
                } while (ch1 == "y");
                Console.WriteLine("Do you want to Run Again :\t");
                ch2 = Console.ReadLine();
            }while(ch2 == "y");
        }
    }
}