using Stragety.Algorithm;
using Stragety.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stragety.Implement
{
    public class FormulaOne : Vehicle
    {
        public FormulaOne()
        {
            SetGoAlgorithm(new GoByDrivingAlgorithm());
        }
    }
}
