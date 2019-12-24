using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trigon.Net.Interface;
using Trigon.Net.SoundEngine;

namespace Trigon.Net
{
    public class Music:Piece
    {
        /// <summary>
        /// BPM值(1分钟内响应的节拍数)
        /// </summary>
        public int Bpm { get; set; } = 60;

        public Music()
        {
            Notes = new List<Beat>();
        }
        /// <summary>
        /// 播放音乐
        /// </summary>
        public void PlayAll()
        {
            string file = "out.wav";
            Render(file);
            using (var audioFile = new AudioFileReader(file))
            using (var outputDevice = new DirectSoundOut(100))
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }
        /// <summary>
        /// 循环播放音乐
        /// </summary>
        public void PlayAllLoop()
        {
            string file = "out.wav";
            Render(file);
            while (true)
            {
                using (var audioFile = new AudioFileReader(file))
                using (var outputDevice = new DirectSoundOut(100))
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(100);
                    }
                }
            }
        }
        /// <summary>
        /// 渲染音乐
        /// </summary>
        /// <param name="outFile">输出文件</param>
        public void Render(string outFile)
        {
            int sleepTime = Convert.ToInt32((60.0 / Bpm) * 1000.0);
            byte[] buffer = new byte[1024];
            var ms = new MemoryStream();
            var rs = new RawSourceWaveStream(ms, new WaveFormat(16000, 16, 2));
            List<ISampleProvider> resultSound = new List<ISampleProvider>();
            int count = 1;
            foreach (var beat in Notes)
            {
                List<ISampleProvider> notesSound = new List<ISampleProvider>();
                foreach (var note in beat.GetNotes())
                {
                    var _reader = new AudioFileReader(note.Instrument.GetFile(note.pName, note.Octive, note.Dynam));
                    _reader.Volume = note.Volume;
                    var outFormat = new WaveFormat(44100, _reader.WaveFormat.Channels);
                    var resampler = new MediaFoundationResampler(_reader, outFormat);
                    var _trimmed = new OffsetSampleProvider(resampler.ToSampleProvider())
                    {
                        Take = new TimeSpan(0, 0, 0, 0, sleepTime * note.Duration)
                    };
                    notesSound.Add(_trimmed);
                }
                count++;
                if (notesSound.Count > 0) {
                    var mixer = new MixingSampleProvider(notesSound);
                    var trimmed = new OffsetSampleProvider(mixer)
                    {
                        DelayBy = TimeSpan.FromMilliseconds(count * sleepTime)
                    };
                    resultSound.Add(trimmed);
                }
            }
            var ResultMixer = new MixingSampleProvider(resultSound);
            WaveFileWriter.CreateWaveFile16(outFile, ResultMixer);
        }
    }
}
