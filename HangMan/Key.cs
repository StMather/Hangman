using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Key
    {
        private string key { get; set; }
        public string answer = "";
       
        
        public Key(string answerIn)
        {
            key = answerIn.ToLower();
            answer = BuildAnswer();
        }

        public override string ToString()
        {
            return key.ToString();
        }

        private string BuildAnswer()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char letter in key)
            {
                sb.Append("-");
            }
            return sb.ToString();
        }

        public bool Evaluate(string letterIn, Guessed guessed)
        {
            bool isIn = false;
            for(int i = 0; i < key.Length;i++ )
            {
                if(letterIn == key[i].ToString())
                {
                    ClearLetter(i);
                    isIn = true;
                     guessed.AddGuess(letterIn);
                }
            }
            isIn = guessed.AddGuess(letterIn);
            return isIn;
        }
        private void ClearLetter(int index)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < key.Length; i++)
            {
                if (i == index)
                {
                    sb.Append(this.key[i]);
                }
                else
                {
                    sb.Append(answer[i]);
                }
            }
            answer = sb.ToString();
        }
        public bool CheckAnswer()
        {
            return key.Equals(answer);
        }

    }
}
