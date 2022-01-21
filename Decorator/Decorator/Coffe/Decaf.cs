using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffe
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
