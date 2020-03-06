using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void SentenceConstructor_CreatesNewInstance_SentenceCheck()
    {
      string inputSentence = "the quick brown fox jumped over the lazy dog";
      string inputWord = "dog";
      SentenceCheck sentenceCheck = new SentenceCheck(inputSentence, inputWord);
      Assert.AreEqual(typeof(SentenceCheck), sentenceCheck.GetType());
    }
     [TestMethod]
      public void TurnToArray_TurnsInputSentenceIntoArray_Char()
      {
      string inputSentence = "I like turtles";
      string inputWord = "dog";
      SentenceCheck sentenceCheck = new SentenceCheck(inputSentence, inputWord);
      string[] array = sentenceCheck.TurnToArray(inputSentence);
      string[] convertedArr = {"I", "like", "turtles"};
      CollectionAssert.AreEqual(array, convertedArr);
      }
    [TestMethod]
    public void WordContains_ReturnsNumberOfTimesWordIfFoundInSentence_Int()
    {
      string inputSentence = "the quick brown fox jumped over the lazy dog";
      string inputWord = "the";
      SentenceCheck sentenceCheck = new SentenceCheck(inputSentence, inputWord);
      string[] array = sentenceCheck.TurnToArray(inputSentence);
      int score = sentenceCheck.WordContains(array, inputWord);
      Assert.AreEqual(2, score);
    }
    
  }
}