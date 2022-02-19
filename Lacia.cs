using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using Lacia_GUI.Classes;

namespace Lacia_GUI
{
    
    class Lacia
    {
         Time time = new Time();
         Greet greet = new Greet();
         Browser br = new Browser();
         Speaker speak = new Speaker();
         SoundPlayer sound;
         protected bool Check { get; set; }        
        public void LaciaVoice(string input)
        {
            SpeechSynthesizer talk = new SpeechSynthesizer();
            talk.SelectVoiceByHints(VoiceGender.Female);
            talk.Rate = 1;
            talk.Speak(input);

        }
        public void Laciainit()
        {            
            speak.Welcome();             
        }
        public bool LaciaBody(string input)
        {
            
            bool matched = false;
           
            if (!Check)
            {
                Thread.Sleep(1000);
                if (input.Contains("time"))
                {
                    time.Timespell();
                    matched = true;
                }
                else if (input.Contains("date"))
                {
                   Date date = new Date();
                    date.GetDate();
                    matched = true;
                }
                else if (input.Contains("who are you") || input.Contains("tell me about yourself"))
                {
                    sound = new SoundPlayer(Properties.Resources.Lacia);
                    sound.Play();
                    matched = true;
                }
                else if (input.Contains("who")&&input.Contains("created")&&input.Contains("you"))
                {
                    sound = new SoundPlayer(Properties.Resources.Creator);
                    sound.Play();
                    matched = true;
                }
                else if (input.Contains("lacia") && input.Contains("can") && input.Contains("you") && input.Contains("hear") && input.Contains("me"))
                {
                    sound = new SoundPlayer(Properties.Resources.YesIcan);
                    sound.Play();
                    matched = true;
                }
                else if (input.Contains("open"))  
                {
                    Thread.Sleep(5000);
                       LaciaVoice(br.Search(input));                      
                        matched = true;                                                       
                }
                else if ((input.Contains("you") && input.Contains("go off") || input.Contains("lacia") && input.Contains("go off"))&& (greet.DoGreet()==4))
                {
                    sound = new SoundPlayer(Properties.Resources.offgreet);
                    sound.Play();
                    matched = true;
                    Check = true;
                    GC.Collect();
                }
                else if (input.Contains("you") && input.Contains("go off") || input.Contains("lacia") && input.Contains("go off"))
                {
                    sound = new SoundPlayer(Properties.Resources.off);
                    sound.Play();
                    matched = true;
                    Check=true;
                    GC.Collect();
                }              
            }
            else
            {
              if (input.Contains("lacia") && (input.Contains("wakeup") || input.Contains("wake up")))
                {
                    RandomWelcome welcome = new RandomWelcome();  //random welcome speech
                    welcome.Welcome();
                    matched = true;
                    Check = false;
                }        
            }       
            return matched;
        }

       
        



    }
}
