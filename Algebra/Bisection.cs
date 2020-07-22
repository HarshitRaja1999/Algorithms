using System;

class Bisection
{
    static float EPSILON =(float)0.01;

    static double function(double x)
    {
        return x*x*x - x*x+2;
    }

    static void bisection(double a , double b)
    {
        if(function(a) * function(b) >=0)
        {
            Console.WriteLine("You have not assumed " + "right a and b");
            return;
        }

        double c = a;
        while((b-a) >= EPSILON)
        {
            c = (a+b)/2;
            if(function(c) == 0.0)
            {
                break;
            }

            else if(function(c) * function(a) <0)
            {
                b=c;
            }

            else
            {
                a=c;
            }
        }
        Console.WriteLine("Value of the Root is : " + c);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Bisection Method :");

        Console.WriteLine("Enter the Value of A :\t");
        var a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Value of B :\t");
        var b = Convert.ToDouble(Console.ReadLine());
        
        bisection(a,b);
    }
}