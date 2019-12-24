using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigon.Net.Enum;

namespace Trigon.Net.Interface
{
    public abstract class Iinstrument
    {
        public abstract string GetFile(PName pname, int octive, int dynam);
    }
}
