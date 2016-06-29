using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SimpleFactory
{
    class Environmental
    {
        public void run()
        {
            LightSimpleFactory factory = new LightSimpleFactory();

            ILight bulb = factory.Create("BulbLight");
            bulb.TurnOn();
            bulb.TurnOff();

            Console.WriteLine("-----------------------------");

            ILight tube = factory.Create("TubeLight");
            tube.TurnOn();
            tube.TurnOff();

        }
    }
}
