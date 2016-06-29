using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Composite.SavePattern
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth));
        }
    }
}
