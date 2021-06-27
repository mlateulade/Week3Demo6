using System;

class MainClass {
  public static void Main (string[] args) {
    //Find the very first number divisible by 4

    for (int i=1; i<=10; i++)
    {
      Console.WriteLine("Enter a number");
      int num = Convert.ToInt32(Console.ReadLine());
      if (num % 4 == 0)
      {
        Console.WriteLine("Number is divisible by 4; Will exit loop now");      
        break;        
      }

    }

  Console.WriteLine("Out of the loop");
  }
}