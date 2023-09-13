using System;

namespace lab2a
{
    public class Temperature_Adviser
    {
        static void Main()
        {
            Console.WriteLine("Please enter the temperature");

            int temp = Convert.ToInt32(Console.ReadLine());     // temperature input 

            if (temp <= 30)     // ask if number is less or equal to 30
            {
                Console.WriteLine("Hope you enjoy your day!");
            }
            else 
            { 
                Console.WriteLine("It's hot out there, remember to drink water and stay in shades!");
            }


        }
    }
    
    public class Exam_Grader
    {
        static void Main()
        {
            Console.WriteLine("Please enter your score");   

            int score = Convert.ToInt32(Console.ReadLine());    // test score input
            
            if(score >= 90 && score == 100)     // ask if score is between 90 - 100
            {
                Console.WriteLine("A");     // if so will be graded as an A
            }
            else if(score >= 80 && score <= 89)     
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 && score <= 79)    
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score <= 69)    
            {
                Console.WriteLine("D");
            }
            else    // if score is not between 60-100
            {
                Console.WriteLine("Please retake the test");    // will be ask to retake the test
            }
        
        }
    
    
    }
}
