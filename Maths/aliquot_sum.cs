using System;
using System.Collections.Generic;
using System.Linq;

class Aliquot_Sum
{
    void aliquot_sum(int num)
    {
        List<int> dividers = new List<int>();
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                dividers.Add(i);
            }
        }

        double total = dividers.Sum();

        Console.WriteLine("The Total is :\t" + total);
    }

    public void Run()
    {
        Console.WriteLine("Aliquot_Sum :");
        Console.WriteLine("Enter the Number :");
        var number = Convert.ToInt32(Console.ReadLine());

        aliquot_sum(number);
    }
}

