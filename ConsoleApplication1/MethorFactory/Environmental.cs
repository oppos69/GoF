using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MethorFactory
{
    class Environmental
    {
        public void run()
        {
            ICreator c1 = new BulbCreator();
            ICreator c2 = new TubeCreator();

            ILight l1 = c1.factory();
            ILight l2 = c2.factory();

            Console.WriteLine("*******************************");

            l1.TurnOn();
            l1.TurnOff();
            l2.TurnOn();
            l2.TurnOff();

        }
    }
}
