using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Round
    {
        public static bool Run(Key key, Guessed guessed)
        {
            string currentLetter = InPut.GetSingleLetter();
            return key.Evaluate(currentLetter, guessed);
        }
    }
}
