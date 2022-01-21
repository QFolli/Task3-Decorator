using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Condiments
{
    abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }
}
