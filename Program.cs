using System;

namespace GuessingCGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string guessTheColour = "Red";
            string guess = "";
            bool outOfGuesses = false;
            var guessLimit = 3;
            var guessCount = 0;

            while(guess != guessTheColour && !outOfGuesses)

            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Guess a number in between 1 and 10: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            
        }

    }
}
