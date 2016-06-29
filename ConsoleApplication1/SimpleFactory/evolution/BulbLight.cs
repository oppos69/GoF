using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SimpleFactory.evolution
{
    class BulbLight: Product
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
