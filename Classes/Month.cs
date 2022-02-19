using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Lacia_GUI.Classes
{
    internal class Month
    {
        SoundPlayer player;
        public void GetMonth(int month)
        {
            Checkmonth(month);
        }

        private void Checkmonth(int number)
        {
            switch (number)
            {
                case 1:
                    {
                        player = new SoundPlayer(Properties.Resources.Jan);
                        player.PlaySync();
                    }break;
                case 2:
                    {
                        player = new SoundPlayer(Properties.Resources.Feb);
                        player.PlaySync();
                    }
                    break;
                case 3:
                    {
                        player = new SoundPlayer(Properties.Resources.March);
                        player.PlaySync();
                    }
                    break;
                case 4:
                    {
                        player = new SoundPlayer(Properties.Resources.April);
                        player.PlaySync();
                    }
                    break;
                case 5:
                    {
                        player = new SoundPlayer(Properties.Resources.May);
                        player.PlaySync();
                    }
                    break;
                case 6:
                    {
                        player = new SoundPlayer(Properties.Resources.Jun);
                        player.PlaySync();
                    }
                    break;
                case 7:
                    {
                        player = new SoundPlayer(Properties.Resources.Jul);
                        player.PlaySync();
                    }
                    break;
                case 8:
                    {
                        player = new SoundPlayer(Properties.Resources.Aug);
                        player.PlaySync();
                    }
                    break;
                case 9:
                    {
                        player = new SoundPlayer(Properties.Resources.Sep);
                        player.PlaySync();
                    }
                    break;
                case 10:
                    {
                        player = new SoundPlayer(Properties.Resources.Oct);
                        player.PlaySync();
                    }
                    break;
                case 11:
                    {
                        player = new SoundPlayer(Properties.Resources.Nov);
                        player.PlaySync();
                    }
                    break;
                case 12:
                    {
                        player = new SoundPlayer(Properties.Resources.Dec);
                        player.PlaySync();
                    }
                    break;

            }
        }
    }
}
