using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SimpleFactory
{
    class BulbLight : ILight
    {
        public void TurnOff()
        {
            Console.WriteLine("Bulb Light is Turned Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Bulb Light is Turned On");
        }
    }
}
