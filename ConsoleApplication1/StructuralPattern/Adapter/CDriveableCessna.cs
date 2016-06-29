using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Adapter
{
    class CDriveableCessna : CCessna, ICar
    {
        public void Drive()
        {
            base.Fly();
        }
    }
}
