using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigon.Net.Interface
{
    public interface ISoundEngine
    {
        void Play(string file,double volume);
    }
}
