using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trigon.Net.Enum;
using Trigon.Net.Instrument;
using Trigon.Net.Interface;

namespace Trigon.Net.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //MetalCore();
            //Console.ReadLine();

            //Iinstrument drum = new Drum();
            //Iinstrument piano = new Piano();
            //Music m = new Music();
            //Piece drumPiece = new Piece();//创建段落区块，区块与区块可以合并。
            //Piece PianoPiece = new Piece();

            //Piece Intro = new Piece();//开头
            //Piece MainPiece = new Piece();//主歌
            //m.Bpm = 240;

            //m.PlayAllLoop();
            clannad cl = new clannad();
            cl.Play();
            Console.ReadLine();
        }

        public static void MetalCore()
        {
            Music m = new Music();
            m.Bpm = 540;
            MetalCore core = new MetalCore();
            Piano piano = new Piano();
            Piece Intro = new Piece();
            Intro[0].Add(core, PName.OpenHat);
            Intro[4].Add(core, PName.OpenHat);
            Intro[8].Add(core, PName.OpenHat);
            Intro[12].Add(core, PName.OpenHat);
            Intro.Create();
            Intro.Create();
            Intro.Create();
            #region BKD 段落1
            Piece Break1 = new Piece();
            Break1[0].Add(core, PName.Crash).Add(core, PName.OpenHat);
            Break1[4].Add(core, PName.Crash);
            Break1[8].Add(core, PName.Crash).Add(core, PName.Snare, 1, 16, 60, 1);
            Break1[12].Add(core, PName.Crash);
            Break1.Create();
            Break1.Create();
            Break1.Create();
            var kicks = GetRandomUnrepeatArray(0, 15, 5);
            foreach(int i in kicks)
            {
                Break1[i].Add(core, PName.Kick,1,2,60,0.8F);
            }
            #endregion
            Thread.Sleep(100);
            #region BKD 段落2
            Piece Break2 = new Piece();
            Break2[0].Add(core, PName.Crash).Add(core, PName.OpenHat);
            Break2[4].Add(core, PName.Crash);
            Break2[8].Add(core, PName.OpenHat).Add(core, PName.Snare,1,16,60,1);
            Break2[12].Add(core, PName.Crash);
            Break2.Create();
            Break2.Create();
            Break2.Create();
            var kicks2 = GetRandomUnrepeatArray(0, 15, 5);
            foreach (int i in kicks2)
            {
                Break2[i].Add(core, PName.Kick, 1, 2, 60, 0.8F);
            }
            #endregion
            Thread.Sleep(100);
            #region BKD 段落3
            Piece Break3 = new Piece();
            Break3[0].Add(core, PName.Crash).Add(core, PName.OpenHat);
            Break3[4].Add(core, PName.Crash);
            Break3[8].Add(core, PName.OpenHat).Add(core, PName.Snare, 1, 16, 60, 1);
            Break3[12].Add(core, PName.Crash);
            Break3.Create();
            Break3.Create();
            Break3.Create();
            var kicks3 = GetRandomUnrepeatArray(0, 15, 5);
            foreach (int i in kicks3)
            {
                Break3[i].Add(core, PName.Kick, 1, 2, 60, 0.8F);
            }
            #endregion

            #region 钢琴段落
            //Piece mainPiano = new Piece();
            //Piece pnPiece = new Piece();
            //pnPiece[0].Add(piano,PName.C,4,8,60,0.5F);
            //pnPiece[6].Add(piano, PName.G, 3, 8, 60, 0.5F);
            //pnPiece[12].Add(piano, PName.Eb, 4, 8, 60, 0.5F);
            //pnPiece[18].Add(piano, PName.D, 4, 8, 60, 0.5F);
            ////var pns= GetRandomUnrepeatArray(0, 15, 24);
            //var a = pnPiece[63];
            //mainPiano.AddPiece(pnPiece);
            //mainPiano.AddPiece(pnPiece);
            //mainPiano.AddPiece(pnPiece);
            //mainPiano.AddPiece(pnPiece);
            #endregion

            #region 空段落
            Piece empty = new Piece();
            //a = empty[63];
            #endregion
            m.AddPiece(Intro);
            m.AddPiece(Break1);
            m.AddPiece(Break2);
            m.AddPiece(Break1);
            m.AddPiece(Break2);
            m.AddPiece(Break1);
            m.AddPiece(Break3);
            m.AddPiece(Break1);
            m.AddPiece(Break2);
            m.AddPiece(Intro);
            m.AddPiece(Intro);
            m.AddPiece(Break1);
            m.AddPiece(Break2);
            //m.AddPieceAt(mainPiano, 16);
            //m.AddPieceAt(mainPiano, 18);
            //m.AddPieceAt(mainPiano, 20);
            //m.AddPieceAt(mainPiano, 22);
            m.PlayAllLoop();
        }

        public static int[] GetRandomUnrepeatArray(int minValue, int maxValue, int count)
        {
            Random rnd = new Random();
            int length = maxValue - minValue + 1;
            byte[] keys = new byte[length];
            rnd.NextBytes(keys);
            int[] items = new int[length];
            for (int i = 0; i < length; i++)
            {
                items[i] = i + minValue;
            }
            Array.Sort(keys, items);
            int[] result = new int[count];
            Array.Copy(items, result, count);
            return result;
        }
    }
}
