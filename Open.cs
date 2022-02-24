using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;
namespace Lacia_GUI
{
    class Open
    {
        string user = Environment.UserName;
        public string Search(string input)
        {
            SoundPlayer player;
            string check = input.Replace("open",null).Replace("google",null).Replace("youtube", null).Replace("and",null).Replace("search",null);           
            string speak= "";
            if (input.Contains("google"))
            {
                string google = "https://www.google.com/search?q=" + check;
                System.Diagnostics.Process.Start(google);
                player = new SoundPlayer(Properties.Resources.Itsopen);
                player.Play();
            }
            else if (input.Contains("youtube") && input.Contains("and") && input.Contains("search"))
            {
                System.Diagnostics.Process.Start("https://www.youtube.com"+check);
                player = new SoundPlayer(Properties.Resources.Itsopen);
                player.Play();
            }
            else if (input.Contains("spotify"))
            {
                System.Diagnostics.Process.Start(@"C:\Users\{0}\AppData\Roaming\Spotify\Spotify.exe",user);
                player = new SoundPlayer(Properties.Resources.spotify);
                player.Play();
            }
            else if (input.Contains("github"))
            {
                System.Diagnostics.Process.Start("https://github.com");
                player = new SoundPlayer(Properties.Resources.Itsopen);
                player.Play();
            }
            else if (input.Contains("whatsapp") || input.Contains("whats app") || input.Contains("what'sapp") || input.Contains("what's app"))
            {
                System.Diagnostics.Process.Start("https://web.whatsapp.com");
                player = new SoundPlayer(Properties.Resources.Itsopen);
                player.Play();
            }
            else if (input.Contains("chess"))
            {
                System.Diagnostics.Process.Start("https://www.chess.com");
                player = new SoundPlayer(Properties.Resources.Itsopen);
                player.Play();
            }
            else if(input.Contains("discord"))
            {
                System.Diagnostics.Process.Start(@"C:\Users\"+user+@"\Desktop\Discord.lnk");
                player = new SoundPlayer(Properties.Resources.Discord);
                player.Play();
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
