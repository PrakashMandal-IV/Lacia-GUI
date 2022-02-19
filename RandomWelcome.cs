using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Lacia_GUI
{
    internal class RandomWelcome
    {
        private Random welcome = new Random();
        private SoundPlayer player;
        private int Rand { get; set; }
        private string NewWelcome { get; set; }
        public RandomWelcome()
        {
            Rand = welcome.Next(1, 6);
        }

        public void Welcome()
        {
            if (Rand == 1)
            {
                player = new SoundPlayer(Properties.Resources.AlwaysAwake);
                player.Play();
            }
            else if (Rand == 2)
            {
                player = new SoundPlayer(Properties.Resources.Atyourservice);
                player.Play(); ;
            }
            else if (Rand == 3)
            {
                player = new SoundPlayer(Properties.Resources.IamUp);
                player.Play();
            }
            else if (Rand == 4)
            {
                player = new SoundPlayer(Properties.Resources.WaitForYou);
                player.Play();
            }
            else if (Rand == 5)
            {
                player = new SoundPlayer(Properties.Resources.IneverSleep);
                player.Play();
            }
            
        }
    }
}
