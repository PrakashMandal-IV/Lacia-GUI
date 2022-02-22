using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Lacia_GUI.Classes
{
    internal class Calculator
    {
        Counter speak = new Counter();
        private int answer;
        Numgen num = new Numgen();
        SoundPlayer player;
        public void Add(string input)
        {
                int number = num.ConvertToNumbers(input);
                answer +=number;
                player = new SoundPlayer(Properties.Resources.KeyPress);
                player.PlaySync();
        }
        public void Sub(string input)
        {
            int number = num.ConvertToNumbers(input);
            answer += number;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Mult(string input)
        {          
            int number = num.ConvertToNumbers(input);
            answer *= number;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Div(string input)
        {
            int number = num.ConvertToNumbers(input);
            answer /=number;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Square(string input)
        {
            int number = num.ConvertToNumbers(input);
            int square = number*number;
            answer= square;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Fact(string input)
        {
            int number = num.ConvertToNumbers(input);
            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            answer = result;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }

        public void Answer()
        {
           speak.Spell(answer);       
        }
        public void Reset()
        {
            answer = 0;
        }
    }
}
