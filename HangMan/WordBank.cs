using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class WordBank
    {
        private static List<string> wordBank = new List<string>()
        {
            "test",
            "greeting",
            "goodbye",
            "hello",
            "word",
        };
        public static string GetWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, wordBank.Count);
            return wordBank[randomIndex];
        }

    }
}
