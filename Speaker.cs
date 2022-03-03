using System.Media;



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
                         speak = new SoundPlayer(Properties.Resources.Morning);
                        speak.PlaySync();
                    } break;
                   
                case 2:
                    {
                        speak = new SoundPlayer(Properties.Resources.Afternoon);
                        speak.PlaySync();
                    }
                    break;
                case 3:
                    {
                        speak = new SoundPlayer(Properties.Resources.Evening);
                        speak.PlaySync();
                    }break;                    
                default:
                    {
                        speak = new SoundPlayer(Properties.Resources.Evening);
                        speak.PlaySync();
                    }break;
                    
            }
            
        }
    }
}
