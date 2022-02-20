using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Lacia_GUI.Classes
{
    internal class Talkback
    {
        SoundPlayer player;
        private bool movies = false;
        private bool games = false;
        private bool lovecheck = true;
        private bool mastcheck = false;
        public void love()
        {
            if(lovecheck)
            {
                player = new SoundPlayer(Properties.Resources.Idonot);
                player.PlaySync();
                lovecheck = false;
            }
            else
            {
                player = new SoundPlayer(Properties.Resources.IamAlgorithm);
                player.PlaySync();
                lovecheck = true;
            }
        }

        public void MoviesGames(string input)
        {
            
            if (input.Contains("movies"))
            {
                if (!movies)
                {
                    player = new SoundPlayer(Properties.Resources.Idontwatchmovies);
                    player.PlaySync();
                    movies = true;
                }
                else
                {
                    player = new SoundPlayer(Properties.Resources.IsaidIdontMovies);
                    player.PlaySync();
                }
            }
            else if(input.Contains("games"))
            {
                if(input.Contains("which"))
                {
                    games = true;
                }
                else if(input.Contains("do"))
                {
                    games=false;
                }
             
                if (!games)
                {
                    player = new SoundPlayer(Properties.Resources.YesIdo);
                    player.PlaySync();
                    games = true;
                }
                else
                {
                    player = new SoundPlayer(Properties.Resources.LikeGames);
                    player.PlaySync();
                }
            }
        }
        public void mast()
        {
            if(!mastcheck)
            {
                player = new SoundPlayer(Properties.Resources.NotYourConcern);
                player.PlaySync();             
                mastcheck = true;
            }
            else
            {
                player = new SoundPlayer(Properties.Resources.YesIdo);
                player.PlaySync();
            }
        }

    }
}
