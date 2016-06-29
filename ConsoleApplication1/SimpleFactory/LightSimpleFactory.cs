using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.SimpleFactory
{
    class LightSimpleFactory
    {
        public ILight Create(string LightType)
        {
            switch (LightType)
            {
                case "TubeLight":
                    return new TubeLight();
                    
                case "BulbLight":
                    return new BulbLight();
                default:
                    return null;
                    
            }
        }
    }
}
