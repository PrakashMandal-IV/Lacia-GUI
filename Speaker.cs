﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

using System.Reflection;

namespace Lacia_GUI
{
    internal class Speaker
    {
        Greet greet = new Greet();
        SoundPlayer speak;
        public Speaker()
        {
            
        }
        public void Welcome()
        {      
            switch (greet.DoGreet()) {
                case 1: 
                    {
                         speak = new SoundPlayer(Properties.Resources.WelMorning);
                        speak.PlaySync();
                    } break;
                   
                case 2:
                    {
                        speak = new SoundPlayer(Properties.Resources.WelAfternoon);
                        speak.PlaySync();
                    }
                    break;
                case 3:
                    {
                        speak = new SoundPlayer(Properties.Resources.WelEvening);
                        speak.PlaySync();
                    }break;                    
                   

                case 4:
                    {
                        speak = new SoundPlayer(Properties.Resources.WelEvening);
                        speak.PlaySync();
                    }
                    break;
            }
            
        }
    }
}
