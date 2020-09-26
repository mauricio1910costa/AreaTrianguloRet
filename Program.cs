using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A área é dada pela metade do produto da base pela altura.");
            double b = 3;
            double h = 5;
            double a = 2;
            double area = b * h / a;
            Console.WriteLine($"{b} * {h} / {a} = {area} ");
            


            
        }
    }
}
