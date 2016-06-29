using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    class Director
    {
        public Product Construct(Builder build)
        {
            build.BuilderA();
            build.BuilderB();
            return build.GetResult();
        }
    }
}
