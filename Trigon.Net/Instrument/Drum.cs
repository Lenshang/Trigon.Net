using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigon.Net.Enum;
using Trigon.Net.Interface;

namespace Trigon.Net.Instrument
{
    public class Drum : Iinstrument
    {
        public override string GetFile(PName pname, int octive, int dynam)
        {
            switch (pname)
            {
                case PName.Kick:
                    return "wav/底鼓.wav";
                case PName.OpenHat:
                    return "wav/开放擦.wav";
                case PName.Snare:
                    return "wav/军鼓.wav";
                case PName.CloseHat:
                    return "wav/踩擦.wav";
            }
            return "";
        }
    }
}
