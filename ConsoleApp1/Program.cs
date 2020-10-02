using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite pervoe chislo:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite vtoroe chislo:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite tretie chislo:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Srednie arefmeticheskoe:");
            double sa = (a + b + c) / 3;
            Console.WriteLine(sa);
            Console.WriteLine("... :");
            int r = (2 * (a + c)) - (3 * b);
            Console.WriteLine(r);
            Console.Write("New text");
            Console.Write("New text2");
            Console.WriteLine("Enter your name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(name + " " + "loh");
            Console.ReadKey();
        }
    }
}
