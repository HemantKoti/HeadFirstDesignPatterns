namespace StrategyPattern.Behavior.Fly
{
    internal class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}