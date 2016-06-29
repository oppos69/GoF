using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    class ConcreteBuilder2 : Builder
    {
        private Product product;

        public ConcreteBuilder2()
        {
            product = new Product();
        }
        public override void BuilderA()
        {
            product.Add("partA");
        }

        public override void BuilderB()
        {
            product.Add("PartB");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
