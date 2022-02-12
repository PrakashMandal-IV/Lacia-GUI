using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Lacia_GUI
{
    
    internal class Lacia
    {
         Greet greet = new Greet();
        public void LaciaVoice(string input)
        {
            SpeechSynthesizer talk = new SpeechSynthesizer();
            talk.SelectVoiceByHints(VoiceGender.Female);
            talk.Rate = 1;
            talk.Speak(input);

        }
        public void Laciainit()
        {
            LaciaVoice("Hello Sir, " + greet.DoGreet()+ ", This is Lacia, your Assistant, How can i help you ");
        }
    }
}
