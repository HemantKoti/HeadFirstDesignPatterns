using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;

namespace StrategyPattern.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
        }

        public override string Display()
        {
            return "Decoy Duck";
        }
    }
}
