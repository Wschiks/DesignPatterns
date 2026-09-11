using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.QuackBehaviors;
using StrategyPattern.FlyBehaviors;
using StrategyPattern.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
            swimBehavior = new FloatBehavior();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
