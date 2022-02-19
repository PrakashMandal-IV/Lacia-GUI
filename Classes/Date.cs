using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Lacia_GUI.Classes
{
    internal class Date
    {
        Counter date = new Counter();
        Month mont = new Month();
        private int datee;
        private int month;
        private int year;
 
        public Date()
        {
            this.datee = DateTime.Now.Day;
            this.month = DateTime.Now.Month;
            this.year = DateTime.Now.Year;
        }
        public void GetDate()
        {                     
            int firstDigits = year / 100;
            float divider = ((year / 100f) - firstDigits) * 100;
            int lastdigit = Convert.ToInt32(divider);
            SoundPlayer its = new SoundPlayer(Properties.Resources.Its);
            its.PlaySync();
            date.Spell(datee);
            mont.GetMonth(month);
            date.Spell(firstDigits);
            date.Spell(lastdigit);



        }
    }
}
