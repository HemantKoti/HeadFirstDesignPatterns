using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behavior.Fly
{
    public class FlyRockedPowered : IFlyBehavior
    {
        public string Fly()
        {
            return "I am flying like a rocket";
        }
    }
}
