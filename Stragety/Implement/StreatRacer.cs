using Stragety.Algorithm;
using Stragety.Base;

namespace Stragety.Implement
{
    public class StreatRacer : Vehicle
    {
        public StreatRacer()
        {
            SetGoAlgorithm(new GoByDrivingAlgorithm());
        }
    }
}