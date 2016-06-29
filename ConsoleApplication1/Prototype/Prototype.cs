using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Prototype
{
    abstract class Prototype
    {
        private int Id;

        public Prototype(int id)
        {
            this.Id = id;
        }

        public int ID { get { return this.Id; } }

        public abstract Prototype Clone();
    }
}
