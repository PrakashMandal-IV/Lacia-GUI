using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacia_GUI
{
    internal class Greet
    {
        
                
        public int DoGreet()
        {
            string time = DateTime.Now.ToString("tt");
            DateTime current = DateTime.Parse(DateTime.Now.ToString("h tt"));
            DateTime morning = DateTime.Parse("12 PM");
            DateTime afternoon = DateTime.Parse("4 PM");
            DateTime evening = DateTime.Parse("7 PM");
            DateTime night = DateTime.Parse("4 AM");
            int m1 = DateTime.Compare(current, night);     // 1 
            int m2 = DateTime.Compare(current, morning);   // -1

            int a1 = DateTime.Compare(current, morning);  //1
            int a2 = DateTime.Compare(current, afternoon); //-1

            int e1 = DateTime.Compare(current, afternoon); //1
            int e2 = DateTime.Compare(current, evening); //-1
            int result;
            if(time.Contains("AM"))
            {
                result = 1;
            }
            else
            {
                if(current>=afternoon)
                {
                    result = 3;
                }
                else
                {
                    result = 2;
                }

            }
            /*
            if (m1 > 0 && m2 < 0)
            {
                result = 1;
            }
            else if (a1 > 0 && a2 < 0)
            {
                result = 2;
            }
            else if (e1 > 0 && e2 < 0)
            {
                result = 3;
            }
            else
            {
                result = 3;
            }*/
            return result;
        }
        


        }
    }

