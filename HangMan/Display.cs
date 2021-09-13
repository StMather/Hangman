using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Display
    {
        public static void DisplayAnswer(Key answerIn)
        {
            Console.WriteLine($"Guess this word: {answerIn.answer}");
        }
        public static void DisplayKey(Key answerIn)
        {
            //for testing may remove
            //Console.WriteLine(answerIn.k);
        }
            public static void DisplayChances(int chancesIn)
        {
            Console.WriteLine($"You have {chancesIn} chances remaining.");
        }

        public static void DisplayPast(Guessed guessIn)
        {
            Console.WriteLine($"Guessed so far:{guessIn.ShowGuesses()}");
        }
    }
}
