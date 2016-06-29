using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MethorFactory
{
    class BulbCreator : ICreator
    {
        public override ILight factory()
        {
            return new BulbLight();
        }
    }
}
