using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SimpleFactory
{
    public class TubeLight:ILight
    {
        public void TurnOff()
        {
            Console.WriteLine("Tube Light is Turned Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Tube Light is Turned On");
        }
    }
}
