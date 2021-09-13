using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class StandardMessages
    {
        public static void Start()
        {
            Console.WriteLine("Welcome to Hangman");
        }
        public static void Rules()
        {
            Console.WriteLine("Objective: Figure out the word.");
            Console.WriteLine("Enter one letter at a time.");
            //Console.WriteLine("Or guess the whole word"); if ther is time to implement
            Console.WriteLine("You will have 8 chances, if you enter a wrong letter you lose a chance!");
        }
        public static void GetChar()
        {
            Console.WriteLine("Please enter a letter:");
        }
        public static void Lose(Key keyIn)
        {
            Console.WriteLine("You have lost!");
            Console.WriteLine($"Your word was: {keyIn.ToString()}");

        } 
        public static void Win()
        {
            Console.WriteLine("You have won this game!");  
        }


    }
}
