using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;

namespace StrategyPattern.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetQuackBehavior(new Quacks());
            SetFlyBehavior(new FlyNoWay());
        }

        public override string Display()
        {
            return "Model Duck";
        }
    }
}
