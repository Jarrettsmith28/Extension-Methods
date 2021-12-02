//Create an extension method that takes reads an
//integer and converts it to a secret message. (GetSecretMessage).
//The secret message will be the one it meets
//the criteria for first in the following order. 
//42 returns "That is the answer".
//0 will return "Nothing".
//Negative numbers will return "Don't be so negative".
//Multiples of 7 will return the message "What a lucky number".
//Multiples of 13 will return the message "Oh, bad luck".
//Odd values will return "Gee, that is odd".
//Even values will return "Looks even to me".
namespace ExtensionMethods
{
  using System;
  using ExtensionMethods;
  public static class MyExtensions
  {
    public static string GetSecretMessage(this int a)
    {
      string zeroString = "nothing";
      string theAnswer = "That is the answer";
      string negativeNum = "Don't be so Negative";
      string luckySeven = "What a lucky number";
      string thirteenNum = "Oh, bad luck";
      string oddValue = "Gee, that is odd";
      string evenValue = "Looks even to me";
      string invalid = "invalid entry";
      

      if (a == 0)
      {
        return zeroString;
      }
      else if (a == 42)
      {
        return theAnswer;
      }
      else if (a < 0)
        {
        return negativeNum;
      }
      else if (a%7 == 0)
      {
        return luckySeven;
      }
      else if (a%13 == 0)
      {
        return thirteenNum;
      }
      else if (a % 2 == 1)
      {
        return oddValue;
      }
      else if (a % 2 == 0)
      {
        return evenValue;
      }
      else 
      {
        return invalid;
      }
    }
  }
}

  namespace ExtensionMethodsDemo1
  {
    using System;
  using ExtensionMethods;
    
    class ExtMethodDemo
  {
    static void Main(string[] args)
    {

      int x = 4;
      var secretMessage = x.GetSecretMessage();
      Console.WriteLine($"{x} has the following message {secretMessage}");

    }
     
  }
 
}

