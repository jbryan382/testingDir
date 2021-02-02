using System;
using System.Collections.Generic;

namespace ShuffleExample
{
  class Program
  {
    static void Main(string[] args)
    {
      // List of numbers in order
      var numValues = new List<string>() {"One", "Two", "Three", "Four", "Five", "Six"};
      var numbers = new List<string>() {"1", "2", "3", "4", "5", "6"};

      var numList = new List<string>();

      foreach (var selectedNumeral in numbers)
      {
        foreach (var selectedWritten in numValues)
        {
          var fullNumber = $"{selectedNumeral} of {selectedWritten}";
          numList.Add(fullNumber);
        }
      }
      Console.WriteLine($"-------------------------------------------");

      foreach (var num in numList)
      {
        Console.WriteLine($"{num}");
        
      }

      // numberOfNumbers = length of our deck
      var numberOfNumbers = numValues.Count;

      // for rightIndex from numberOf - 1 down to 1 do:
        // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
      for (var rightIndex = numberOfNumbers-1; rightIndex >= 0; rightIndex--)
      {
       var leftIndex = new Random().Next(0, rightIndex);
        // Now swap the values at rightIndex and leftIndex by doing this:

        // leftCard = the value from deck[leftIndex]
        // var leftNum = numValues[leftIndex];
        // rightCard = the value from deck[rightIndex]
        var rightNum = numValues[rightIndex];
        // deck[rightIndex] = leftCard
        numValues[rightIndex] = numValues[leftIndex];
        // deck[leftIndex] = rightCard
        numValues[leftIndex] = rightNum;
      }

      Console.WriteLine($"-------------------------------------------");

      foreach (var num in numValues)
      {
        Console.WriteLine($"{num}");
        
      }
    }
  }
}
