using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class CheckLetter
    {
        private static List<string> allowed = new List<string>()
        {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",

        };
        public static bool Check(string stringIn)
        {
            
            if (stringIn.Length > 1)
            {
                Console.WriteLine($"\"{stringIn}\" is not one letter");
                return false;
            }
            else
            {
                foreach(string check in allowed)
                {
                    if(check == stringIn)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
