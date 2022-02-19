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

        public string Search(string input)
        {
            string check = input.Replace("open",null).Replace("google",null).Replace("youtube", null).Replace("and",null).Replace("search",null).Replace(" ",null);

            string speak= "";
            if (input.Contains("google"))
            {
                string google = "https://www.google.com/search?q=" + check;
                System.Diagnostics.Process.Start(google);
                speak = "searching google";
            }
            else if (input.Contains("youtube") && (check == null))
            {
                System.Diagnostics.Process.Start("https://www.youtube.com");
                speak = "opening youtube";
            }
            else if (input.Contains("spotify"))
            {
                System.Diagnostics.Process.Start(@"C:\Users\Prakash\AppData\Roaming\Spotify\Spotify.exe");
                speak = "enjoy the songs";
            }
            else if (input.Contains("github"))
            {
                System.Diagnostics.Process.Start("https://github.com");
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
                speak = "opening discord";
            }
            else if (input.Contains("my art"))
            {
                System.Diagnostics.Process.Start(@"G:\Digital Art\FOR INSTA.jpg");
            }
            else if(input.Contains("black desert"))
            {
                System.Diagnostics.Process.Start(@"G:\Pearlabyss\BlackDesert\BlackDesertLauncher.exe");
            }
            return speak;
        }
    }
}
