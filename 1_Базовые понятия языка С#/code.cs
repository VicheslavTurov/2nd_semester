using System;

namespace BaseCSharpTasks
{
  class Program
  {
    static void Main(string[] args) {
      // Task 1: Power calculation using only multiplication
      int baseNumber;
      int powerValue;
      long powerResult;

      Console.Write("Enter base number (a): ");
      baseNumber = int.Parse(Console.ReadLine());

      Console.Write("Enter power value (n): ");
      powerValue = int.Parse(Console.ReadLine());

      powerResult = 1;
      int multiplicationIndex = 0;

      while (multiplicationIndex < powerValue) {
        powerResult = powerResult * baseNumber;
        multiplicationIndex = multiplicationIndex + 1;
      }

      Console.WriteLine("\nResult of a^n calculation:" + baseNumber + "^" + powerValue + " = " + powerResult + "\n");

      // Task 2: Remove second digit and append it to the end
      string inputNumber;
      char secondDigit;
      string numberWithoutSecondDigit;
      string finalNumber;

      Console.Write("Enter number x (x >= 100): ");
      inputNumber = Console.ReadLine();

      secondDigit = inputNumber[1];
      numberWithoutSecondDigit = inputNumber.Remove(1, 1);
      finalNumber = numberWithoutSecondDigit + secondDigit;

      Console.WriteLine("\nResult after transformation:" + "n = " + finalNumber + "\n");
    }
  }
}