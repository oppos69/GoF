using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Adapter
{
    class CToyota : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Vroom Vroom,we're off in our Toyota");
        }
    }
}
