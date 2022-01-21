using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    class Whip : CondimentDecorator
    {
        private protected Beverage beverageDecorateTo;
        public Whip(Beverage beverage)
        {
            this.beverageDecorateTo = beverage;
            this.description = beverageDecorateTo.GetDescription() + " + Whip";
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override double Cost()
        {
            return beverageDecorateTo.Cost() + 0.10;
        }
    }
}
