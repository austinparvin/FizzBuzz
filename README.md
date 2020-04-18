# Fizz Buzz Code Kata

A console app used to solve this [kata](https://www.codewars.com/kata/5300901726d12b80e8000498)

## Includes:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [if/else iteration logic](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else)

## Problem

- Count from 1 to 100
- Check each num
- if div by 3 print "fizz"
- if div by 5 print "buzz"
- if div by 15 print "fizzbuzz"

# Featured Code

## If/Else Iteration Logic
```C#
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
```

## App In Action
![](https://i.imgur.com/qNkQcNM.png)
