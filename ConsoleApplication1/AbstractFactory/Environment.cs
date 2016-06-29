using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.AbstractFactory
{
    class Environment
    {
        public void run(IAbstractFactory factory)
        {
            IAbstractProductA p1 = factory.CreateProductA();
            IAbstractProductB p2 = factory.CreateProductB();

            p2.Interact(p1);
        }

        public void Create()
        {
            IAbstractFactory factoryA = new ConcreteFactory2();
            run(factoryA);

            IAbstractFactory factoryB = new ConcreteFactory1();
            run(factoryB);
        }
    }
}
