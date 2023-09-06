using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Eric";
      Console.WriteLine(name);  
      int number = 24;  //int use for whole number
      Console.WriteLine(number);
     char Letter = 'M';  //char only use for single letter
     Console.WriteLine(Letter);
     double height = 177.8;  // double use for decimal
     Console.WriteLine(height);
     string text = "Studing at UVU?";
     Console.WriteLine(text);
     bool UVU = true;  // bool is for ture or false
     Console.WriteLine(UVU);
     bool BYU = false;
     string question = "Studing at BYU?";
     Console.WriteLine(question);
     Console.WriteLine(BYU);
     int Sum1 = 100 + 20;
     int Sum2 = Sum1 + 80;
     int Sum3 = Sum2 - 150;
     Console.WriteLine(Sum1);
     Console.WriteLine(Sum2);
     Console.WriteLine(Sum3);
     int Sum4 = Sum3 * 5;  // * means times
     Console.WriteLine(Sum4);
     int Sum5 = Sum4 / 10;  // / means divide 
     Console.WriteLine(Sum5);
     Console.WriteLine(Sum1 % Sum5);  // % is returns after division remainder
     int Sum6 = Sum1;
     Sum6++;  //++ is +1
     Console.WriteLine(Sum6);
     int Sum7 = Sum2;
     Sum7--;  // -- is -1
     Console.WriteLine(Sum7);
    int x = 100;
    Console.WriteLine(x + Sum2);
    int y = 200;
    Console.WriteLine(x + y);
    Console.WriteLine(x - y);
    Console.WriteLine(x * y);
    Console.WriteLine(y / x);
     
     }
  }
}
