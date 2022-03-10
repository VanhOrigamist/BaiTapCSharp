using System;
namespace P1E3
{
    class CSharpNguVcl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(x,3)*2+((x*x)*5)+7*x+15);
            Console.WriteLine(Math.Pow(Math.Sin(x),2)+Math.Pow(Math.Cos(2*x),2)+Math.Pow(Math.Tan(3*x),2));
            Console.WriteLine(Math.Pow((x+10),(x+5)));
            Console.WriteLine(3*(Math.Exp(Math.Cos((x+1)))));
            Console.WriteLine(Math.Log((x+100)));
            Console.ReadLine();
        }
    }
}   
