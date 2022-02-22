using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Lacia_GUI.Classes
{
     class Counter
    {
        SoundPlayer speak;
        public void Spell(int number)
        {

            if (number < 20)
            {
                Countninteen(number);
            }
            else if(number >=20 && number<100)
            {
                int FirstDigit = number/ 10;
                int startingNumber = FirstDigit * 10;
                float fraction = ((number / 10f) - FirstDigit) * 10;
                int lastdigit = Convert.ToInt32(fraction);
                tense(startingNumber);
                Countninteen(lastdigit);
            }
            else if(number == 100)
            {
                speak = new SoundPlayer(Properties.Resources._100);
                speak.PlaySync();
            }
            else if(number >100)
            {
                int firstDigit = number/ 100;
                int secondDigit = number%100;
                int secndDigitintense = secondDigit / 10;
                int thirddigit = number % 10;
                Countninteen(firstDigit);
                speak = new SoundPlayer(Properties.Resources._100);
                speak.PlaySync();
                tense(secndDigitintense);
                Countninteen(thirddigit);
            }
        }

        private void Countninteen(int input)
        {
            
            switch (input)
            {
                case 1:
                    {
                        speak = new SoundPlayer(Properties.Resources._1);
                        speak.PlaySync();
                    }
                    break;
                case 2:
                    {
                        speak = new SoundPlayer(Properties.Resources._2);
                        speak.PlaySync();
                    }
                    break;
                case 3:
                    {
                        speak = new SoundPlayer(Properties.Resources._3);
                        speak.PlaySync();
                    }
                    break;
                case 4:
                    {
                        speak = new SoundPlayer(Properties.Resources._4);
                        speak.PlaySync();
                    }
                    break;
                case 5:
                    {
                        speak = new SoundPlayer(Properties.Resources._5);
                        speak.PlaySync();
                    }
                    break;
                case 6:
                    {
                        speak = new SoundPlayer(Properties.Resources._6);
                        speak.PlaySync();
                    }
                    break;
                case 7:
                    {
                        speak = new SoundPlayer(Properties.Resources._7);
                        speak.PlaySync();
                    }
                    break;
                case 8:
                    {
                        speak = new SoundPlayer(Properties.Resources._8);
                        speak.PlaySync();
                    }
                    break;
                case 9:
                    {
                        speak = new SoundPlayer(Properties.Resources._9);
                        speak.PlaySync();
                    }
                    break;
                case 10:
                    {
                        speak = new SoundPlayer(Properties.Resources._10);
                        speak.PlaySync();
                    }
                    break;
                case 11:
                    {
                        speak = new SoundPlayer(Properties.Resources._11);
                        speak.PlaySync();
                    }
                    break;
                case 12:
                    {
                        speak = new SoundPlayer(Properties.Resources._12);
                        speak.PlaySync();
                    }
                    break;
                case 13:
                    {
                        speak = new SoundPlayer(Properties.Resources._13);
                        speak.PlaySync();
                    }
                    break;
                case 14:
                    {
                        speak = new SoundPlayer(Properties.Resources._15);
                        speak.PlaySync();
                    }
                    break;
                case 15:
                    {
                        speak = new SoundPlayer(Properties.Resources._14);
                        speak.PlaySync();
                    }
                    break;
                case 16:
                    {
                        speak = new SoundPlayer(Properties.Resources._16);
                        speak.PlaySync();
                    }
                    break;
                case 17:
                    {
                        speak = new SoundPlayer(Properties.Resources._17);
                        speak.PlaySync();
                    }
                    break;
                case 18:
                    {
                        speak = new SoundPlayer(Properties.Resources._18);
                        speak.PlaySync();
                    }
                    break;
                case 19:
                    {
                        speak = new SoundPlayer(Properties.Resources._19);
                        speak.PlaySync();
                    }
                    break;
                }
            }
        private void tense(int input)
        {
            switch (input)
            {
                case 20:
                    {
                        speak = new SoundPlayer(Properties.Resources._20);
                        speak.PlaySync();
                    }break;
                case 30:
                    {
                        speak = new SoundPlayer(Properties.Resources._30);
                        speak.PlaySync();
                    }
                    break;
                case 40:
                    {
                        speak = new SoundPlayer(Properties.Resources._40);
                        speak.PlaySync();
                    }
                    break;
                case 50:
                    {
                        speak = new SoundPlayer(Properties.Resources._50);
                        speak.PlaySync();
                    }
                    break;
                case 60:
                    {
                        speak = new SoundPlayer(Properties.Resources._60);
                        speak.PlaySync();
                    }
                    break;
                case 70:
                    {
                        speak = new SoundPlayer(Properties.Resources._70);
                        speak.PlaySync();
                    }
                    break;
                case 80:
                    {
                        speak = new SoundPlayer(Properties.Resources._80);
                        speak.PlaySync();
                    }
                    break;
                case 90:
                    {
                        speak = new SoundPlayer(Properties.Resources._90);
                        speak.PlaySync();
                    }
                    break;

            }
        }
    }
}
