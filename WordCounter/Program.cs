using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  { 
    public static void EndState()
    {
      Console.WriteLine("would you like to try again? [y] yes [n] no");
      string answer = Console.ReadLine();
      if (answer == "y")
      {
        FunThings();
      }
      else if (answer == "n")
      {
        Console.WriteLine("Thanks for playing. Goodbye");
      }
      else
      {
        EndState();
      }
    }
    public static void FunThings()
    {
      SentenceCheck sentenceCheck = new SentenceCheck();
      Console.WriteLine("Enter a sentence, word phrase or anything you would like to have checked");
      string inputSentence = Console.ReadLine();
      Console.WriteLine("Great! Now Enter a word you would like me to check for in the previous Input");
      string inputWord = Console.ReadLine();
      string[] array = sentenceCheck.TurnToArray(inputSentence);
      int score = sentenceCheck.WordContains(array, inputWord);
      Console.WriteLine("searching........../n searching........../n searching............./n and done!");
      if (score < 1)
        {
          Console.WriteLine("It seems the word you input was not found within the phrase you entered.");
        }
        else if (score == 1)
        {
          Console.WriteLine("we found the word " + inputWord + "in the phrase " + score + "time!");
        }
        else
        {
          Console.WriteLine("we found the word " + inputWord + "in the phrase " + score + " times!");
        }
      EndState();
      
      
    }
    public static void Main()
    {
      Console.WriteLine("Hello User, what is your name");
      string name = Console.ReadLine();
      Console.WriteLine("Hello " + name + "  welcome to the Word Checker 4000, This robot over here has you put in a string of words. you can then enter any word you would like and the robot will tell you how many times that word appears in the previously entered info. sound fun? Here, try it out");
      Console.WriteLine("press space to continue");
      Console.ReadLine();
      
     FunThings();
    }
  }
}