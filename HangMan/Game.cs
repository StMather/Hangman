using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Game
    {
        public static void RunGame()
        {
            bool gameOn = true;
            int chances = 8;//
            Guessed guessed = new Guessed();
            StandardMessages.Rules();
            Key key = new Key(WordBank.GetWord());
            while (gameOn)
            { 
                Display.DisplayAnswer(key);
                //Display.DisplayKey(key);//////remove for final game
                Display.DisplayChances(chances);
                Display.DisplayPast(guessed);
               if (!Round.Run(key, guessed))
                {
                    chances = chances - 1;
                }

                gameOn = WinLose(chances, key);
            }
        }
        private static bool WinLose(int chancesIn, Key keyIn)
        {
            if(chancesIn <=0)
            {
                StandardMessages.Lose(keyIn);
                return false;
            }
            if(keyIn.CheckAnswer())
            {
                StandardMessages.Win();
                return false;
            }
            return true;
        }
    }

}
