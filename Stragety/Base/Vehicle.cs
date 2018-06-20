using Stragety.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stragety.Base
{
    public abstract class Vehicle
    {
        private IGoAlgorithm goAlgorithm;
        public Vehicle()
        {

        }

        public void SetGoAlgorithm(IGoAlgorithm algorithm)
        {
            goAlgorithm = algorithm;
        }

        public void Go()
        {
            goAlgorithm.Go();
        }
    }
}
