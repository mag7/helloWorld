using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Pythagorean
    {
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }
        public decimal Hypotenuse { get; set; }

        public Pythagorean(decimal a, decimal b)
        {
            Side1 = a;
            Side2 = b;
        }
    }
}
