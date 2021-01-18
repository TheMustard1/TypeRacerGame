using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacerGame
{
    class TextViewer
    {
        public string sentence = "This doesn't.";

        public string showText()
        {
            Console.WriteLine(sentence);
            return sentence;
        }
    }
}
