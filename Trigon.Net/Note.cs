using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigon.Net.Enum;
using Trigon.Net.Interface;

namespace Trigon.Net
{
    public class Note
    {
        /// <summary>
        /// 音名
        /// </summary>
        public PName pName { get; set; }
        /// <summary>
        /// 八度
        /// </summary>
        public int Octive { get; set; } = 1;
        /// <summary>
        /// 响度
        /// </summary>
        public float Volume { get; set; }
        /// <summary>
        /// 力度
        /// </summary>
        public int Dynam { get; set; } = 60;
        /// <summary>
        /// 时值
        /// </summary>
        public int Duration { get; set; } = 1;
        /// <summary>
        /// 乐器
        /// </summary>
        public Iinstrument Instrument { get; set; }
    }
}
