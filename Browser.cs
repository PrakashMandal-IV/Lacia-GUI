using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Lacia_GUI
{
    class Browser
    {

        public void Search(string input)
        {
            if (input.Contains("google"))
            {
                System.Diagnostics.Process.Start("https://www.google.com");
            }
            else if (input.Contains("youtube"))
            {
                System.Diagnostics.Process.Start("https://www.youtube.com");
            }
            else if (input.Contains("spotify"))
            {
                System.Diagnostics.Process.Start(@"C:\Users\Prakash\AppData\Roaming\Spotify\Spotify.exe");
            }
            else if (input.Contains("github"))
            {
                System.Diagnostics.Process.Start(" https://github.com");
            }
            else if (input.Contains("whatsapp") || input.Contains("whats app") || input.Contains("what'sapp") || input.Contains("what's app"))
            {
                System.Diagnostics.Process.Start("https://web.whatsapp.com");
            }
            else if (input.Contains("chess"))
            {
                System.Diagnostics.Process.Start("https://www.chess.com");
            }
            else if(input.Contains("discord"))
            {
                System.Diagnostics.Process.Start(@"C:\Users\Prakash\Desktop\Discord.lnk");
            }
            else if (input.Contains("my art"))
            {
                System.Diagnostics.Process.Start(@"G:\Digital Art\FOR INSTA.jpg");
            }
            else if(input.Contains("black desert"))
            {
                System.Diagnostics.Process.Start(@"G:\Pearlabyss\BlackDesert\BlackDesertLauncher.exe");
            }
        }
    }
}
