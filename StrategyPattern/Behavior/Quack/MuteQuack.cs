namespace StrategyPattern.Behavior.Quack
{
    internal class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "Silence";
        }
    }
}