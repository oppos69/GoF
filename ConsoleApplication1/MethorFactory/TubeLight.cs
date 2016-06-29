using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MethorFactory
{
    class TubeLight : ILight
    {
        public override void TurnOff()
        {
            Console.WriteLine("Tube Light is Turned Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Tube Light is Turned On");
        }
    }
}
