using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Composite.SavePattern
{
    class Composite : Component
    {
        public Composite(string name) : base(name) { }
        public ArrayList childen = new ArrayList();
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component item in childen)
            {
                item.Display(depth + 2);
            }
        }


        public void Add(Component item)
        {
            childen.Add(item);
        }

        public void Remove(Component item)
        {
            childen.Remove(item);
        }

    }
}
