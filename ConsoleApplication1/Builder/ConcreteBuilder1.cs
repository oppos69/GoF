using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    class ConcreteBuilder1 : Builder
    {
        private Product product;

        public ConcreteBuilder1(Product model)
        {
            product = model;
        }
        public override void BuilderA()
        {
            product.Add("PartA");
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
