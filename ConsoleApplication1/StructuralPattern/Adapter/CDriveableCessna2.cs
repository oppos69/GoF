using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.StructuralPattern.Adapter
{
    class CDriveableCessna2 : ICar
    {
        CCessna m_oContained;

        public CDriveableCessna2()
        {
            m_oContained = new CCessna();
        }
        public void Drive()
        {
            m_oContained.Fly();
        }
    }
}
