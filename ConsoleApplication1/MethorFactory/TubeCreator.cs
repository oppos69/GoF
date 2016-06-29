using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MethorFactory
{
    class TubeCreator : ICreator
    {
        public override ILight factory()
        {
            return new TubeLight();
        }

    }
}
