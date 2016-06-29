using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SimpleFactory.evolution
{
    class Product
    {
        public virtual void TurnOff()
        {
            
        }

        public virtual void TurnOn()
        {
            
        }

        public static Product Create(string LightType)
        {
            if (LightType == "Bulb")
            {
                return new BulbLight();
            }
            else if (LightType == "Tube")
            {
                return new TubeLight();
            }
            return null;
        }
    }
}
