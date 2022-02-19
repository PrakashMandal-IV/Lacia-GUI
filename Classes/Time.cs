using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Lacia_GUI.Classes
{
     class Time
    {    
        
        Counter time = new Counter();
        public void Timespell()
        {
            int hour=DateTime.Now.Hour;
            int minute  = DateTime.Now.Minute;
            string daynight = DateTime.Now.ToString("tt");
           
            SoundPlayer player;
            if (DateTime.Now.Hour > 12)
            {
                int Hour = DateTime.Now.Hour;
                hour = Hour - 12;
            }
            else { }
            
            if(minute <= 20)
            {
                SoundPlayer its = new SoundPlayer(Properties.Resources.Its);
                its.PlaySync();
                time.Spell(hour);
                time.Spell(minute);
                if(daynight=="AM")
                {
                    player= new SoundPlayer(Properties.Resources.AM);
                    player.Play();
                }
                else
                {
                   player = new SoundPlayer(Properties.Resources.Pm);
                    player.Play();
                }
            }
            else
            {
                int FirstDigit = minute / 10;
                int finalMinute = FirstDigit * 10;
                float fraction = ((minute / 10f) - FirstDigit) * 10;
                int show = Convert.ToInt32(fraction);
                SoundPlayer its = new SoundPlayer(Properties.Resources.Its);
                its.PlaySync();
                time.Spell(hour);
                time.Spell(finalMinute);
                time.Spell(show);
                if (daynight == "AM")
                {
                    player = new SoundPlayer(Properties.Resources.AM);
                    player.Play();
                }
                else
                {
                    player = new SoundPlayer(Properties.Resources.Pm);
                    player.Play();
                }
            }

        }
      
    }
}
