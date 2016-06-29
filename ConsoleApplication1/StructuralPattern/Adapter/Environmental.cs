using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Adapter
{
    class Environmental
    {
        public void run()
        {
            ICar oCar = new CToyota();
            Console.WriteLine("Class Adaper : Driving an Automobile");
            oCar.Drive();
            oCar = new CDriveableCessna();
            Console.WriteLine("Drive a Cessna");
            oCar.Drive();
            oCar = new CDriveableCessna2();
            Console.WriteLine("Object Adaper:Driving a Cessna");
            oCar.Drive();
        }
    }
}
