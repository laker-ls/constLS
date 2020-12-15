using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstLS.Memory.RawParameters
{
    interface IRawParameters
    {
        float x();
        float y();
        float z();
        int type();
        int HP();
        int maxHP();
    }
}
