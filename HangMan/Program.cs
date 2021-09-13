using System;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.Start();
            Game.RunGame();

            /*
             * START
             * -----------------------
                -welcome to hangman
	                -how to play
            -----------------------------
                -word is chosen randomly
                -Display blanked out word
                -Display chances left
                -display letters used
            -----------------------------------
                -Get user input(getchar?)
	                -Verify it is a letter
                -check if letter is in word && has not been used
	                -Add letter to blanked out word(Loop or string)
	                or	
	                -Remove chance and add leter to used
            --------------------------------------
                -Check win condition
                    -if win/lose conditions not met go to 20
                -display WIn or Lose
                -Ask if they want to play again(if yes got to 15 else quit)
            */
        }
    }
}
