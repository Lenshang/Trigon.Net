using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trigon.Net.Interface;
namespace Trigon.Net.SoundEngine
{
    class WavPlayer : ISoundEngine
    {
        //SoundPlayer player { get; set; }
        public WavPlayer()
        {
            //player = new SoundPlayer();
        }
        public void Play(string file, double volume)
        {
            Task.Run(() => {
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
            });
            //var player = new SoundPlayer();
            //player.SoundLocation = file;
            //player.Play();
        }
    }
}
