using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class InPut
    {
        public static string GetSingleLetter()
        {
            StandardMessages.GetChar();
            string currentLetter = Console.ReadLine().ToLower();
            while(!CheckLetter.Check(currentLetter))
            {
                currentLetter = GetSingleLetter();
            }
            return currentLetter;
            
        }
    }
}
