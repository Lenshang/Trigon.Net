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
    /// <summary>
    /// Clannad 插曲 潮鳴り
    /// </summary>
    class clannad
    {
        public void Play()
        {
            Iinstrument drum = new Drum();
            Iinstrument piano = new Piano();
            Music m = new Music();
            Piece drumPiece = new Piece();//创建段落区块，区块与区块可以合并。
            Piece PianoPiece = new Piece();

            Piece Intro = new Piece();//开头
            Piece MainPiece = new Piece();//主歌
            m.Bpm = 150;
            int pieceCount = 0;
            Piece P1 = new Piece();
            Piece P2 = new Piece();
            #region 钢琴节奏
            Piece pianoRythm = new Piece();
            Piece pianoRythm1 = new Piece();
            pianoRythm1.Create().Add(piano,PName.F,2,8,60,0.7F);
            pianoRythm1.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm1.Create().Add(piano, PName.E, 3, 8, 60, 0.7F);
            pianoRythm1.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm1.Create().Add(piano, PName.F, 2, 8, 60, 0.7F);
            pianoRythm1.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm1.Create().Add(piano, PName.E, 3, 8, 60, 0.7F);
            pianoRythm1.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);

            Piece pianoRythm2 = new Piece();
            pianoRythm2.Create().Add(piano,PName.G,2, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.B, 2, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.D, 3, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.B, 2, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.G, 2, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.B, 2, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.D, 3, 8, 60, 0.7F);
            pianoRythm2.Create().Add(piano, PName.B, 2, 8, 60, 0.7F);

            Piece pianoRythm3 = new Piece();
            pianoRythm3.Create().Add(piano, PName.A, 2, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.E, 3, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.A, 2, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.E, 3, 8, 60, 0.7F);
            pianoRythm3.Create().Add(piano, PName.C, 3, 8, 60, 0.7F);
            pianoRythm.AddPiece(pianoRythm1);
            pianoRythm.AddPiece(pianoRythm2);
            pianoRythm.AddPiece(pianoRythm3);
            pianoRythm.AddPiece(pianoRythm3);
            pieceCount = pianoRythm.GetNotes().Count();
            pianoRythm.GetNotes().Select(i => i.GetNotes().Select(ii => ii.Volume = 0.3F));
            #endregion

            #region 钢琴主音
            Piece pianoSolo = new Piece();
            pianoSolo[0].Add(piano, PName.A, 3);
            pianoSolo[1].Add(piano, PName.E, 4);
            pianoSolo[2].Add(piano, PName.A, 3);
            pianoSolo[3].Add(piano, PName.G, 3);
            pianoSolo[4].Add(piano, PName.A, 3);

            pianoSolo[11].Add(piano, PName.G, 3);
            pianoSolo[12].Add(piano, PName.A, 3);
            pianoSolo[13].Add(piano, PName.E, 4);
            pianoSolo[14].Add(piano, PName.A, 3);
            pianoSolo[15].Add(piano, PName.G, 3);
            pianoSolo[16].Add(piano, PName.A, 3);
            pianoSolo[17].Add(piano, PName.E, 4);
            pianoSolo[18].Add(piano, PName.A, 3);
            pianoSolo[19].Add(piano, PName.G, 3);
            pianoSolo[20].Add(piano, PName.A, 3);
            pianoSolo[23].Add(piano, PName.E, 3);
            pianoSolo[24].Add(piano, PName.G, 3);

            pianoSolo[27].Add(piano, PName.D, 3);
            pianoSolo[28].Add(piano, PName.E, 3);
            pianoSolo[29].Add(piano, PName.G, 3);
            pianoSolo[30].Add(piano, PName.A, 3);
            pianoSolo[31].Add(piano, PName.B, 3);
            pianoSolo[32].Add(piano, PName.A, 3);
            pianoSolo[33].Add(piano, PName.E, 4);
            pianoSolo[34].Add(piano, PName.A, 3);
            pianoSolo[35].Add(piano, PName.G, 3);
            pianoSolo[36].Add(piano, PName.A, 3);

            pianoSolo[43].Add(piano, PName.G, 3);
            pianoSolo[44].Add(piano, PName.A, 3);
            pianoSolo[45].Add(piano, PName.E, 4);
            pianoSolo[46].Add(piano, PName.B, 3);
            pianoSolo[47].Add(piano, PName.C, 4);
            pianoSolo[48].Add(piano, PName.B, 3);
            pianoSolo[49].Add(piano, PName.C, 4);
            pianoSolo[50].Add(piano, PName.B, 3);
            pianoSolo[51].Add(piano, PName.A, 3);
            pianoSolo[52].Add(piano, PName.E, 3);

            pianoSolo[59].Add(piano, PName.D, 3);
            pianoSolo[60].Add(piano, PName.E, 3);
            pianoSolo[61].Add(piano, PName.G, 3);
            pianoSolo[62].Add(piano, PName.A, 3);
            pianoSolo[63].Add(piano, PName.B, 3);
            #endregion

            #region 鼓节奏
            Piece DrumPiece1 = new Piece();
            DrumPiece1.Create().Add(drum,PName.OpenHat).Add(drum,PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Snare);
            DrumPiece1.Create().Add(drum, PName.CloseHat);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Snare);
            DrumPiece1.Create().Add(drum, PName.CloseHat);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Snare);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Kick);
            DrumPiece1.Create().Add(drum, PName.CloseHat).Add(drum, PName.Snare);
            DrumPiece1.Create().Add(drum, PName.CloseHat);
            #endregion

            P1.AddPiece(pianoRythm);
            P1.AddPiece(pianoRythm);
            P1.AddPieceAt(pianoSolo, 0);

            P2.AddPiece(DrumPiece1);
            P2.AddPiece(DrumPiece1);
            P2.AddPiece(DrumPiece1);
            P2.AddPiece(DrumPiece1);
            P2.AddPieceAt(P1, 0);
            m.AddPiece(P1);
            m.AddPiece(P2);
            m.PlayAll();
        }
    }
}
