using System;

namespace GuessingCGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string guessTheColour = "red";
            string guess = "";
            bool outOfGuesses = false;
            var guessLimit = 3;
            var guessCount = 0;

            while(guess != guessTheColour && !outOfGuesses)

            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Guess a Colour that I am thinking of: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if(guess == guessTheColour)

            {
                Console.Write("Well done you guessed correctly");
            }
            else
             {
                Console.Write("Sorry your'e wrong and ran out of guesses");
            }

        }

    }
}
