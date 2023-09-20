using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any numbers");

        int num = Convert.ToInt32(Console.ReadLine());

        int x; 
        
        int y; 

        for (y = 1; y <= num; y++) // set my outter loop vertical row to 1 if y is less or equal to the given number y will increase by 1 
        {
            for (x = 1; x <= y; x++) // set my inner loop parallel row to 1 if x is less or equal to y, x will increase by 1
            {
                Console.Write(y); // only print the number for y
            }
            Console.Write("\n"); // creat a new line

        }
    }
}
