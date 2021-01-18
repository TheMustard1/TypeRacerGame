using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var TextViewer = new TextViewer();
            var UserInput = new UserInput();
            var SentenceVerifier = new SentenceVerifier();
            
            string sentence = TextViewer.showText();
            string text = UserInput.userInput();

            SentenceVerifier.verify(text, sentence);

            Console.ReadKey();
        }
    }
}
