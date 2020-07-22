using System;
using System.Linq;
using System.Collections.Generic;

namespace Maths
{
    class MMM
    {
        static void Mean(List<int> numbers)
        {
            double mean;
            mean = (float)(numbers.Sum()/numbers.Count());

            Console.WriteLine("Mean :\t" + mean);
        }

        static void Meadian(List<int> numbers)
        {
            int meadian ,n;

            n = ((numbers.Count()) + 1)/2 ; 
            meadian = numbers[n-1];

            Console.WriteLine("Median :\t" + meadian);
        }

        static void Mode(List<int> numbers)
        {        
            int mod;
            Dictionary<int, int> freqMap = numbers.GroupBy(x => x).Where(g => g.Count() > 1).ToDictionary(x => x.Key, x => x.Count());
            mod = freqMap.Values.Max();
            Console.WriteLine("Mode :\t" + mod);
       }

        public void Run()
        {
            string ch1,ch2;
            int b;
            do
            {   
                List<int> Number = new List<int>();
                Console.Write("Enter the Numbers with space :\t");
                var a = Console.ReadLine();
                Number.AddRange(a.Split(' ').Select(int.Parse).ToList());
                do
                {
                    Console.Write("Enter the Choice :\n" + "1. Mean , 2. Mode , 3. Median :\t");
                    b = int.Parse(Console.ReadLine());

                    switch (b)
                    {
                        case 1 :
                            Mean(Number);
                            break;
                        
                        case 2 :
                            Mode(Number);
                            break;

                        case 3 :
                            Meadian(Number);
                            break;

                        default:
                            Console.Write("Enter Correct Choice :\t");
                            break;
                    }
                    Console.WriteLine("Run Another Function :\t");
                    ch2 = Console.ReadLine();                    
                }while(ch2 == "y");
                Console.WriteLine("Do you want to run again(y/n) :\t");
                ch1 = Console.ReadLine();
            }while(ch1 == "y");
            
        }
    }
}