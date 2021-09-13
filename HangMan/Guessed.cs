using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Guessed
    {
        protected List<string> guessed = new List<string>();
        

        public Guessed()
        {

        }

        public bool AddGuess(string letterIn)
        {
            foreach  (string x in guessed)
            {
                if (letterIn.Equals(x))
                {
                    return true;
                }
            }
            guessed.Add(letterIn);
            return false;
        }
        public string ShowGuesses()
        {
            return string.Join(",", guessed.ToArray());
        }
    }
}
