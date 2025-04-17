using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac37._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"{ myClass.PI()}");
            Console.WriteLine($"{myClass.INT()}");
            Console.WriteLine($"{myClass.XSquare(5)}");
            Console.WriteLine($"{myClass.SquareRootX(9)}");
            Console.Read();

        }
    }
}
