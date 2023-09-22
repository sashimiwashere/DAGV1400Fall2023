using System;

public class Program_Challenge1
{
    static void Main()
    {
        Console.WriteLine("Guess a number between 1 to 10");

        int guess;

        Random random = new Random();

        int num = random.Next(1, 11);

        int count = 0;
        
        do
        {
            guess = Convert.ToInt32(Console.ReadLine());

            count++;  // everytime run this loop count will go up by 1

            if (guess < num)  // if the guess is smaller than 7 show the text tells to guess bigger
            {
                Console.WriteLine("Guess a little bit bigger");
            }
            else if (guess > num)  // if the guess is bigger than 7 show the text tells to guess smaller
            {
                Console.WriteLine("Guess a little bit smaller");
            }
            else  // if guess is not bigger or smaller than the actual number means he got it right
            {
                Console.WriteLine("You got it!");  
                Console.WriteLine(("You got it at the ") + (count) + (" try"));  // shows the count nunber
            }
        }
        while (guess != num);  // if the guess is not equal to the actual number run the loop again
    }
}


public class Program_Challenge2
{
    static void Main()
    {
        Console.WriteLine("Enter 3 favorite foods of yours");

        string food1 = Console.ReadLine();

        string food2 = Console.ReadLine();

        string food3 = Console.ReadLine();

        string[] foods = {food1, food2, food3};

        Array.Sort(foods);

        foreach (string y in foods)
        {
            Console.WriteLine("I love " + y + "!");
        }
    }
}
