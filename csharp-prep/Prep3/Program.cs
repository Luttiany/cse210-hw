using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the 'Guess The Number' game!");
        Random randomGen = new Random ();
        int number = randomGen.Next (1, 101);
        int guessNumber = 0;

        while (number != guessNumber)

        {
            Console.WriteLine ("Please, guess a number from 1 to 100: ");
            guessNumber = int.Parse(Console.ReadLine());
            
            if (number > guessNumber)
            {
                Console.WriteLine ("The number is higher!");
            }

            else if (number < guessNumber)
            {
                Console.WriteLine ("The number is lower!");
            }

            else
            {
                Console.WriteLine ("You guessed the number!!");

            }
            
        }

    }
}