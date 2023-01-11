using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        bool playing = true;
        int guesses = 0;

        while (playing) 
        {
            Console.Write("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());
            guesses += 1;

            if (guess == magicNumber) 
            {
                Console.WriteLine($"You guessed it in {guesses} tries. Good job!");
                playing = false;
            }
            else if (guess >= magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}