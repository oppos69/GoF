using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Adapter
{
    class CCessna
    {
        /// <summary>
        /// Adaptee
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("Static runup OK,we're off in our C172");
        }
    }
}
