using System;

namespace ConsoleApplication1.AbstractFactory
{
    public class ProductB2 : IAbstractProductB
    {
        public ProductB2()
        {
        }

        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this + " Interacts with " + a);
        }
    }

}
