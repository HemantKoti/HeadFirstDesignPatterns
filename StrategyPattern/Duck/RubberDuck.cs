using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;

namespace StrategyPattern.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Squeaks());
        }

        public override string Display()
        {
            return "Rubber Duck";
        }
    }
}
