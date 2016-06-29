using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MethorFactory
{
    class BulbLight : ILight
    {
        public override void TurnOff()
        {
            Console.WriteLine("Bulb Light is Turned Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Bulb Light is Turned On");
        }
    }
}
