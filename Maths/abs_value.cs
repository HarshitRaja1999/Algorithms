using System;

class Absolute_value
{
    static void abs_value(double number)
    {
        if(number < 0)
        {
            Console.WriteLine("The Answer is :\t" + -number);
        }
        else
        {
            Console.WriteLine("The Answer is :\t" + number);
        }
    }

    public static void Run()
    {
        Console.WriteLine("Enter the Value : \t");

        var a = Convert.ToDouble(Console.ReadLine());

        abs_value(a);
    }
}