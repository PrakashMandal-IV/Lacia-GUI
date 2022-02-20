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
        private long answer = 0;
        Numgen num = new Numgen();
        SoundPlayer player;
        public void Add(string input)
        {
                long number = num.ConvertToNumbers(input);
                answer +=number;
                player = new SoundPlayer(Properties.Resources.KeyPress);
                player.PlaySync();
        }
        public void Sub(string input)
        {
            long number = num.ConvertToNumbers(input);
            answer += number;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Mult(string input)
        {
            long number = num.ConvertToNumbers(input);
            answer *= number;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Div(string input)
        {
            long number = num.ConvertToNumbers(input);
            answer /= number;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Square(string input)
        {
            long number = num.ConvertToNumbers(input);
            long square = number*number;
            answer= square;
            player = new SoundPlayer(Properties.Resources.KeyPress);
            player.PlaySync();
        }
        public void Fact(string input)
        {
            long number = num.ConvertToNumbers(input);
            long result = 1;
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
            try
            {
                int finalAnswer = Convert.ToInt32(answer);
                player = new SoundPlayer(Properties.Resources.TheAnswerIs);
                player.PlaySync();
                speak.Spell(finalAnswer);
            }
            catch (Exception )
            {
                player = new SoundPlayer(Properties.Resources.CantDoThat);
                player.PlaySync();
            }          
        }
        public void Reset()
        {
            answer = 0;
        }
    }
}
