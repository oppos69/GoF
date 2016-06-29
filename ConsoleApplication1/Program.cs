using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //***********simplefactory
            //SimpleFactory.Environmental env = new SimpleFactory.Environmental();
            //env.run();

            //**************AbstractFactory
            //AbstractFactory.Environment en = new AbstractFactory.Environment();
            //en.Create();


            //**************Builder
            //Builder.Environmental en = new Builder.Environmental();
            //en.run();

            //**************Adapter
            StructuralPattern.Adapter.Environmental envir = new StructuralPattern.Adapter.Environmental();
            envir.run();

            Console.ReadKey();
            
        }


    }
}
