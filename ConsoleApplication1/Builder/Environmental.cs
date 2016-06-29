using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    class Environmental
    {

        public void run()
        {
            Director dir = new Director();

            ConcreteBuilder1 build1 = new ConcreteBuilder1(new Product());
            ConcreteBuilder2 build2 = new ConcreteBuilder2();

            Product p1 = dir.Construct(build1);
            Product p2 = dir.Construct(build2);

            p1.Show();
            p2.Show();
        }
    }
}
