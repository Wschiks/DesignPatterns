using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.QuackBehaviors;
using StrategyPattern.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new RegularQuack();
            flyBehavior = new FlyWithWings();
            swimBehavior = new FloatBehavior();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
