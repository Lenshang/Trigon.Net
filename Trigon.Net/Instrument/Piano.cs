using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigon.Net.Enum;
using Trigon.Net.Interface;

namespace Trigon.Net.Instrument
{
    public class Piano : Iinstrument
    {
        public override string GetFile(PName pname, int octive, int dynam)
        {
            string file = @"wav\Piano\" + pname.ToString()+octive.ToString()+".wav";
            if (File.Exists(file))
            {
                return file;
            }
            return "";
        }
    }
}
