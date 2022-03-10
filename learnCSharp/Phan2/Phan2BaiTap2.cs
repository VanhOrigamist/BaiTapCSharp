using System;
namespace P2E2
{
    class CSharpNguVcl
    {
        static void Main(string[] args)
        {   
            double x1,x2,x3,y1,y2,y3;
            Console.WriteLine("x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            x3 = (x1+x2)/2;
            y3 = (y1+y2)/2;
            Console.WriteLine("("+x3+", "+y3+")");
            Console.WriteLine(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)));
            Console.ReadLine();
        }
    }
}   
