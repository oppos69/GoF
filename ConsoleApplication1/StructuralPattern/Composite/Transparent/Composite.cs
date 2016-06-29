using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Composite.Transparent
{
    class Composite : Component
    {
        public Composite(string name) : base(name)
        {
        }

        protected ArrayList childen = new ArrayList();

        public override void Add(Component item)
        {
            childen.Add(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth), name);

            foreach (Component item in childen)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component item)
        {
            childen.Remove(item);
        }
    }
}
