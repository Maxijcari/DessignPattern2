using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPattern.StrategyPattern
{
    public class BicycleStrategy:IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un Bici y me estoy moviendo");
        }
    }
}
