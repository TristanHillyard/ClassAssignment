using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int b;
            Console.WriteLine("What number do you want to do math operations on?");
            num1 = Convert.ToInt32(Console.ReadLine());
            b = MathMeth(num1);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
