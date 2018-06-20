using Stragety.Algorithm;
using Stragety.Base;

namespace Stragety.Implement
{
    public class Helicopter : Vehicle
    {
        public Helicopter()
        {
            SetGoAlgorithm(new GoByFlying());
        }
    }
}