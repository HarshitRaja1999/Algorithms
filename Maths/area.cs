using System;
namespace Maths
{
   public class Area
    {
        static float PI = (float)3.14;
        void rectangle()
        {
            Console.Write("Enter Length :\t");
            var length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Breadth :\t");
            var breadth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t"+ length*breadth);
        }
        
        void square()
        {
            Console.Write("Enter Length of Edge :\t");
            var edge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + edge*edge);
        }
        
        void circle()
        {
            Console.Write("Enter Length of Radius :\t");
            var radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + PI*radius*radius);
        }
        
        void cube()
        {
            Console.Write("Enter Length of edge :\t");
            var edge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + 6*Math.Pow(edge,2));
        }
        
        void Sphere()
        {
            Console.Write("Enter Length of Radius :\t");
            var radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + 4*PI*Math.Pow(radius,2));

        }
        
        void triangle()
        {
            Console.Write("Enter Length of Height :\t");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Length of Base :\t");
            var breadth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + (1/2)*breadth*height);
        }
        
        void paralellogram()
        {
            Console.Write("Enter Length of Height :\t");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Length of Breadth :\t");
            var breadth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + breadth*height);

        }

        void trapezium()
        {
            Console.Write("Enter Length of Height :\t");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Length of Breadth  1 :\t");
            var breadth1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Length of Breadth 2 :\t");
            var breadth2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Area :\t" + (1/2)*(breadth1 + breadth2)*height);

        }
        
        public void Run()
        {
            string ch = "";
            int a = 0;
            do
            {
                do
                {
                    Console.Write(" Enter :  \n " + "1. Rectangle , 2. Square , 3. Circle , 4. Cube ,\n 5.Sphere , 6.Triangles , 7.Paralellogram , 8.Trapexium :");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                    switch(a)
                    {
                        case 1 :
                            rectangle();
                            break;

                        case 2 : 
                            square();
                            break;

                        case 3 :
                            circle();
                            break;
                        
                        case 4 :
                            cube();
                            break;
                        
                        case 5 :
                            Sphere();
                            break;
                        
                        case 6 :
                            triangle();
                            break;

                        case 7 :
                            paralellogram();
                            break;

                        case 8 :
                            trapezium();
                            break;

                        default :
                            Console.Write("Enter Correct Choice  : \t");
                            break;
                    }
                }while(a<0 || a>8);
                Console.Write("Do you want to run again :\t");
                ch = Console.ReadLine();
            } while (ch == "y");
        }
    }
}