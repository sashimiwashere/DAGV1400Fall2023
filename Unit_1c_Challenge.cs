using System;

public class Program_Challenge1
{
    static void Main()
    {
        Console.WriteLine("Guess a number between 1 to 10");

        int guess;

        int num = 7;

        int count = 0;
        do
        {
            guess = Convert.ToInt32(Console.ReadLine());

            count++;

            if (guess < num)
            {
                Console.WriteLine("Guess a little bit bigger");
            }
            else if (guess > num)
            {
                Console.WriteLine("Guess a little bit smaller");
            }
            else
            {
                Console.WriteLine("You got it!");
                Console.WriteLine(("You got it at the ") + (count) + (" try"));
            }
        }
        while (guess != num);
    }
}
