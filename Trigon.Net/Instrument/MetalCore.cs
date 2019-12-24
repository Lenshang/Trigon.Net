using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigon.Net.Enum;
using Trigon.Net.Interface;

namespace Trigon.Net.Instrument
{
    public class MetalCore : Iinstrument
    {
        public override string GetFile(PName pname, int octive, int dynam)
        {
            switch (pname)
            {
                case PName.Kick:
                    return "wav/BreakDown/kick.wav";
                case PName.OpenHat:
                    return "wav/BreakDown/hihat.wav";
                case PName.CloseHat:
                    return "wav/踩擦.wav";
                case PName.Snare:
                    return "wav/BreakDown/snare.wav";
                case PName.Crash:
                    return "wav/BreakDown/crash.wav";
            }
            return "";
        }
    }
}
