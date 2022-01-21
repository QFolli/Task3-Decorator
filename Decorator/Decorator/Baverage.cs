using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Beverage
    {
        protected string description = "Unknown beverage";
        public string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
}
