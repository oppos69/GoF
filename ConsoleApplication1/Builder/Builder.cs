using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    abstract class Builder
    {
        abstract public void BuilderA();

        abstract public void BuilderB();

        abstract public Product GetResult();
    }
}
