using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace The_Legend_of_Console
{
    internal class Audio
    {
        
        public static void PlaySound(string soundName)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @$"\data\Sound\{soundName}.wav";
            player.Play();
        }
    }      
}
