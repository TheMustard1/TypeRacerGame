using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacerGame
{
    class SentenceVerifier
    {
        public void verify(string text, string sentence)
        {
            if (text == sentence)
            {
                Console.WriteLine("correct.");
            }
            else
            {
                Console.WriteLine("failed.");
            }
        }
    }
}
