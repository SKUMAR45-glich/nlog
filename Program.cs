using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Addnumbers add = new Addnumbers();
            Console.WriteLine("Result is :" + "" + add.Sum(a, b));
        }
    }
}
