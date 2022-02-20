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
         Talkback say = new Talkback();
         Calculator calculate = new Calculator();
         SoundPlayer sound;
         protected bool Check { get; set; }  
         private bool calInit = false;         
         private string calMode;
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
           
            if (!Check && !calInit)
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
                    sound.PlaySync();
                    matched = true;
                }
                else if (input.Contains("initiate") && input.Contains("calculator"))
                {
                    calInit = true;
                    sound = new SoundPlayer(Properties.Resources.CalInit);
                    sound.PlaySync();
                    matched = true;
                }
                else if (input.Contains("who")&&input.Contains("created")&&input.Contains("you"))
                {
                    sound = new SoundPlayer(Properties.Resources.Creator);
                    sound.PlaySync();
                    matched = true;
                }
                else if (input.Contains("you") && input.Contains("masturbate"))
                {
                    say.mast();
                    matched = true;
                }
                else if (input.Contains("lacia") && input.Contains("can") && input.Contains("you") && input.Contains("hear") && input.Contains("me"))
                {
                    sound = new SoundPlayer(Properties.Resources.YesIcan);
                    sound.PlaySync();
                    matched = true;
                }
                else if ((input.Contains("do") && input.Contains("you") && input.Contains("love") && input.Contains("me"))||(input.Contains("i") && input.Contains("love") && input.Contains("you")))
                {
                    say.love();
                    matched = true;
                }
                else if (input.Contains("lacia") && input.Contains("you") && ((input.Contains("watch")|| (input.Contains("like"))) && input.Contains("movies")|| input.Contains("play") && input.Contains("games")))
                {
                    say.MoviesGames(input);
                    matched = true;
                }
                else if (input.Contains("open"))    //browser
                {
                    Thread.Sleep(5000);
                       LaciaVoice(br.Search(input));                      
                        matched = true;                                                       
                }

                else if ((input.Contains("you") && input.Contains("go off") || input.Contains("lacia") && input.Contains("go off"))&&(greet.DoGreet() == 3))
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
                    sound.PlaySync();
                    matched = true;
                    Check=true;
                    GC.Collect();
                }              
            }
            else if(!calInit)
            {
              if (input.Contains("lacia") && (input.Contains("wakeup") || input.Contains("wake up")))
                {
                    RandomWelcome welcome = new RandomWelcome();  //random welcome speech
                    welcome.Welcome();
                    matched = true;
                    Check = false;
                }        
            }
            else if(calInit)
            {
                if (input.Contains("add") || input.Contains("subtract") || input.Contains("multiply") || input.Contains("divide") || input.Contains("factorial") || input.Contains("square"))
                {

                    if (input.Contains("add"))
                    {
                        sound = new SoundPlayer(Properties.Resources.Add);
                        sound.PlaySync();
                        calMode = "add";
                        matched = true;
                    }
                    else if (input.Contains("multipy"))
                    {
                        sound = new SoundPlayer(Properties.Resources.Multiply);
                        sound.PlaySync();
                        calMode = "multiply";
                        matched = true;
                    }
                    else if (input.Contains("subtract"))
                    {
                        sound = new SoundPlayer(Properties.Resources.Subtract);
                        sound.PlaySync();
                        calMode = "subtract";
                        matched = true;
                    }
                    else if (input.Contains("divide"))
                    {
                        sound = new SoundPlayer(Properties.Resources.Dividing);
                        sound.PlaySync();
                        calMode = "divide";
                        matched = true;
                    }
                    else if (input.Contains("factorial"))
                    {
                        sound = new SoundPlayer(Properties.Resources.Factorial);
                        sound.PlaySync();
                        calMode = "factorial";
                        matched = true;
                    }
                    else if (input.Contains("square"))
                    {
                        sound = new SoundPlayer(Properties.Resources.Squaring);
                        sound.PlaySync();
                        calMode = "square";
                        matched = true;
                    }                
                }
                else if (input.Contains("close") && input.Contains("calculator"))
                {
                    sound = new SoundPlayer(Properties.Resources.GotIt);
                    sound.PlaySync();
                    calculate.Reset();
                    calInit = false;
                    matched = true;
                }
                else if (input.Contains("reset"))
                {
                    sound = new SoundPlayer(Properties.Resources.GotIt);
                    sound.PlaySync();
                    calculate.Reset();
                    calInit = false;
                    matched = true;
                    GC.Collect();
                }
                else if (input.Contains("answer"))
                {
                    calculate.Answer();
                    matched = true;
                }
                else
                {
                    Thread.Sleep(3000);
                    switch (calMode)
                    {
                        case "add":
                            {
                                calculate.Add(input);
                                matched = true;
                            }
                            break;
                        case "subtract":
                            {
                                calculate.Sub(input);
                                matched = true;
                            }
                            break;
                        case "multiply":
                            {
                                calculate.Mult(input);
                                matched = true;
                            }
                            break;
                        case "divide":
                            {
                                calculate.Div(input);
                                matched = true;
                            }
                            break;
                        case "factorial":
                            {
                                calculate.Fact(input);
                                matched = true;
                            }
                            break;
                        case "square":
                            {
                                calculate.Square(input);
                                matched = true;
                            }
                            break;
                    }
                }

            }
            return matched;
        }

       
        



    }
}
