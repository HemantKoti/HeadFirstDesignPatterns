using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;

namespace StrategyPattern.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quacks());
        }

        public override string Display()
        {
            return "Mallard Duck";
        }
    }
}
