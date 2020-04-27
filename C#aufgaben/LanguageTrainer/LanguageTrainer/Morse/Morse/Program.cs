using System;
using System.Threading;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            Console.Write("String to morse -> ");
            string str = Console.ReadLine();

            //Morse it:
            Morse(str);
        }

        static void Flash(int delay)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            Thread.Sleep(delay);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Thread.Sleep(300);
        }

        static void Morse(string str)
        {
            foreach (char c in str)
            {
                //Get the Morse code representation of the current character:
                string morseCode = MorseTable.GetMorseCode(c);

                if (morseCode == " ")
                {
                    Console.WriteLine("<Space>");
                }
                else
                {
                    Console.Write("{0}", morseCode);
                }
                
                Thread.Sleep(1000);

                foreach (char d in morseCode)
                {
                    switch (d)
                    {
                        case '.': Flash(100); break; 
                        case '-': Flash(350); break;
                        case ' ': Flash(1000); break;
                    }
                }
            }
        }
    }
}
