using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Weather Adviser Enhanced Edition");

        Console.WriteLine("Please enter the temperature");

        int temp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The temperature is " + temp + " degrees outside");

        if (temp >= -10 && temp <= 10)
        {
            Console.WriteLine("It's freezing out there, Wear a jacket and stay warm!");
        }

        else if (temp >= 11 && temp <= 20)
        {
            Console.WriteLine("You might need a light jacket If you try to go outside!");
        }

        else if (temp >= 21 && temp <= 30)
        {
            Console.WriteLine("Nice weather, hope you enjoy your day!");
        }

        else if (temp >= 31 && temp <= 40)
        {
            Console.WriteLine("It's hot out there, Grab a water bottle and stay in shades!");
        }

        else
        {
            Console.WriteLine("Extreme weather! Please stay inside the house");
        }
    }

    static void SubSelector()
    {
        Console.WriteLine("Welcome to subject selector");

        Console.WriteLine("Please enter your subject");

        string sub = Console.ReadLine();

        Console.WriteLine("Your subject is " + sub);

        Console.WriteLine("Please enter your score");

        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 90 && score <= 100)
        {
            Console.WriteLine("You have been graded A");
        }
        else if (score >= 80 && score <= 89)
        {
            Console.WriteLine("You have been graded B");
        }
        else if (score >= 70 && score <= 79)
        {
            Console.WriteLine("You have been graded C");
        }
        else if (score >= 60 && score <= 69)
        {
            Console.WriteLine("You have been graded D");
        }
        else
        {
            Console.WriteLine("Please retake the test and try again with the new score");
        }

        

        switch (sub)
        {
            case "Math":
                Console.WriteLine("Math is all about logic, If that make sense to you, you got this!");
                break;

            case "English":
                Console.WriteLine("We use English every single day, you will be comfordent day by day!");
                break;
            
            case "Art":
                Console.WriteLine("Takes alot of pratice, keep doing it, there's always room to be improve!");
                break;

            case "Music":
                Console.WriteLine("Takes alot of pratice, keep doing it, there's always room to be improve!");
                break;
            case "Science":
                Console.WriteLine("Never give up, the wrold is better because you guys!");
                break;
        
        
        
        }

    }
}
