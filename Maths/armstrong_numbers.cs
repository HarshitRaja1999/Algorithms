using System;
namespace Maths
{
    class Armstrong
    {
        static void armstrong(int num)
        {
            int sum =0, rem,temp;
            temp = num;

            while(num > 0)
            {
                rem = num % 10;
                sum = sum + (rem*rem*rem);
                num = num / 10;
            }
            if(temp == sum)
            {
                Console.Write("The Given number is Armstrong Number.");
            }
            else
            {
                Console.Write("The Given Number is Not an Armstrong Number.");
            }
        }

        public void Run()
        {
            Console.Write("Enter the Number :\t");
            var number = int.Parse(Console.ReadLine());

            armstrong(number);
        }
    }
}

