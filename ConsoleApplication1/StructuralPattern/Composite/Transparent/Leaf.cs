using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Composite.Transparent
{
    class Leaf : Component
    {


        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component item)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth));
            
        }

        public override void Remove(Component item)
        {
            Console.WriteLine("Cannot remove to a leaf");
        }
    }
}
