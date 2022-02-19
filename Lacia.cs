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
                    LaciaVoice("It's," + DateTime.Now.ToString("dd/MM/yyyy"));
                    matched = true;
                }
                else if (input.Contains("who are you") || input.Contains("tell me about yourself"))
                {
                    LaciaVoice("My Name is Lacia. Virtual Assistant. Just a sample for now");
                    matched = true;
                }
                else if (input.Contains("open"))  
                {
                    Thread.Sleep(5000);
                       LaciaVoice(br.Search(input));                      
                        matched = true;                                                       
                }
                else if ((input.Contains("you") && input.Contains("go off") || input.Contains("lacia") && input.Contains("go off")))
                {
                    LaciaVoice("Going off, Good Night Sir");
                    matched = true;
                    Check = true;
                    GC.Collect();
                }
                else if (input.Contains("you") && input.Contains("go off") || input.Contains("lacia") && input.Contains("go off"))
                {
                    LaciaVoice("Going off, Have a nice day sir");
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
                    LaciaVoice(welcome.Welcome() + ",   how can i help you");
                    matched = true;
                    Check = false;
                }        
            }       
            return matched;
        }

       
        



    }
}
