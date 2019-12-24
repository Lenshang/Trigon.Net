using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trigon.Net.Enum;
using Trigon.Net.Interface;

namespace Trigon.Net
{
    public class Beat
    {
        private List<Note> _notes { get; set; }
        public Beat()
        {
            _notes = new List<Note>();
        }
        public Beat Add(Note note)
        {
            _notes.Add(note);
            return this;
        }
        public Beat Add(Iinstrument ins, PName pname, int octive=1,int duration=8,int dynam=60,float volume=0.8F)
        {
            Note _n = new Note() {
                Instrument=ins,
                pName= pname,
                Octive=octive,
                Dynam= dynam,
                Volume= volume,
                Duration=duration
            };
            _notes.Add(_n);
            return this;
        }
        public List<Note> GetNotes()
        {
            return this._notes;
        }
    }
}
