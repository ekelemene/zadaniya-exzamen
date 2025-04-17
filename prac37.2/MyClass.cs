using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac37._2
{
    class MyClass : IInterface
    {
        public double PI()
        {
            return Math.PI;
        }
        public int INT()
        {
            return 25;
        }
        public int XSquare(int x)
        {
            return (int)(x * x);
        }
        public double SquareRootX(double x)
        {
            return(double) Math.Sqrt(x);
        }
    }
}
