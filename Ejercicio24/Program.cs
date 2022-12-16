using System;
namespace Ejercicio24
{
    class Program
    {
        static void Main()
        {
            char letter = GiveMeALetter();
            string start = Start(letter);

        }
        enum State { Idle, playing, paused, stopped, closed }
        static string Start(char letter)
        {
            string stringLetter = letter.ToString();
            State state = State.Idle;
            switch (stringLetter)
            {
                case "p":
                    state = State.closed;
                    break;
                case "stopped":
                    state = State.stopped;
                    break;
                case "paused":
                    state = State.paused;
                    break;
                case "playing":
                    state = State.playing;
                    break;
                case "idle":
                    state = State.idle;
                    break;
            }
            return state.ToString();
        }
        static char GiveMeALetter()
        {
            Console.WriteLine("Enter a letter q p or s, the machine is idle");
            //idle inactivo!!
            char letter = Convert.ToChar(Console.ReadLine());
            return letter;
        }
        static string Play (char letter,string start)
        {

        }
    }
}