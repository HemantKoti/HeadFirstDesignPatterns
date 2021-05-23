using StrategyPattern.Behavior.Fly;
using StrategyPattern.Behavior.Quack;

namespace StrategyPattern.Duck
{
    public abstract class Duck
    {
		IFlyBehavior flyBehavior;
		IQuackBehavior quackBehavior;

		public Duck()
		{
		}

		public void SetFlyBehavior(IFlyBehavior fb)
		{
			flyBehavior = fb;
		}

		public void SetQuackBehavior(IQuackBehavior qb)
		{
			quackBehavior = qb;
		}

		public abstract string Display();

		public string PerformFly()
		{
			return flyBehavior.Fly();
		}

		public string PerformQuack()
		{
			return quackBehavior.Quack();
		}

		public string Swim()
		{
			return "All ducks float, even decoys!";
		}
	}
}
