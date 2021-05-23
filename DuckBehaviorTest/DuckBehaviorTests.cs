using NUnit.Framework;
using StrategyPattern.Duck;

namespace DuckBehaviorTest
{
    public class DuckBehaviorTests
    {
        private Duck mallard;
        private Duck model;

        [SetUp]
        public void Setup()
        {
            mallard = new MallardDuck();
            model = new ModelDuck();
        }

        [Test]
        public void MallardDuckTest()
        {
            Assert.Pass();
        }

        [Test]
        public void MallardDuckQuackBehaviorTest()
        {
            string resultQuack = mallard.PerformQuack();

            Assert.AreEqual(resultQuack, "Quack");
        }

        [Test]
        public void MallardDuckFlyBehaviorTest()
        {
            string resultQuack = mallard.PerformFly();

            Assert.AreEqual(resultQuack, "I am flying");
        }

        [Test]
        public void MallardDuckFlyBehaviorTestNegative()
        {
            string resultQuack = mallard.PerformFly();

            Assert.AreNotEqual(resultQuack, "I am not flying");
        }

        [Test]
        public void ModelDuckTest()
        {
            Assert.Pass();
        }

        [Test]
        public void ModelDuckQuackBehaviorTest()
        {
            string resultQuack = model.PerformQuack();

            Assert.AreEqual(resultQuack, "Quack");
        }

        [Test]
        public void ModelDuckQuackBehaviorTestNegative()
        {
            string resultQuack = model.PerformQuack();

            Assert.AreNotEqual(resultQuack, "Does not Quack");
        }

        [Test]
        public void ModelDuckFlyBehaviorTest()
        {
            string resultQuack = model.PerformFly();

            Assert.AreEqual(resultQuack, "I can't fly");
        }
    }
}