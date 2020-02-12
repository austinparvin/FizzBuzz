using System;

namespace FizzBuzz
{
  class Program
  {
    // Count from 1 to 100
    // Check each num
    // if div by 3 print "fizz"
    // if div by 5 print "buzz"
    // if div by 15 print "fizzbuzz"
    static void Main(string[] args)
    {
      for (var i = 1; i <= 100; i++)
      {
        if (i % 15 == 0) {
          Console.WriteLine("fizzbuzz");
        } else if(i % 3 == 0){
          Console.WriteLine("fizz");
        } else if (i % 5 == 0) {
          Console.WriteLine("buzz");
        } else {
          Console.WriteLine(i);
        }
        
      }
    }
  }
}
