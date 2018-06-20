using Stragety.Implement;
using System;

namespace Stragety
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Jet()).Go();
            (new Helicopter()).Go();
            (new StreatRacer()).Go();
            (new FormulaOne()).Go();
            Console.ReadKey();
        }
    }
}
