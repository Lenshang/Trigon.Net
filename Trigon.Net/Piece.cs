using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigon.Net
{
    /// <summary>
    /// 段落
    /// </summary>
    public class Piece
    {
        protected List<Beat> Notes { get; set; }
        public Piece()
        {
            Notes = new List<Beat>();
        }
        public Beat this[int pos]
        {
            get
            {
                while (Notes.Count < pos + 1)
                {
                    Notes.Add(new Beat());
                }
                return Notes[pos];
            }
        }
        public Beat Create()
        {
            var b = new Beat();
            Notes.Add(b);
            return b;
        }
        /// <summary>
        /// 将一个Piece附加在此Piece之后
        /// </summary>
        /// <param name="piece"></param>
        public void AddPiece(Piece piece)
        {
            AddPieceAt(piece, this.Notes.Count());
        }
        /// <summary>
        /// 从[position]位置开始合并Piece到此Piece
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="position"></param>
        public void AddPieceAt(Piece piece, int position)
        {
            int count = 0;
            foreach (var note in piece.GetNotes())
            {
                if (note.GetNotes().Count() == 0)
                {
                    var a = this[position + count];
                }
                foreach (var n in note.GetNotes())
                {
                    this[position + count].Add(n);
                }
                count++;
            }
        }
        public List<Beat> GetNotes()
        {
            return Notes;
        }
    }
}
