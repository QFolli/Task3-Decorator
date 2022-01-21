﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffe
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
