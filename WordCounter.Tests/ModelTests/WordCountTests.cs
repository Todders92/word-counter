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
      SentenceCheck sentenceCheck = new SentenceCheck();
      Assert.AreEqual(typeof(SentenceCheck), sentenceCheck.GetType());
    }
     [TestMethod]
      public void TurnToArray_TurnsInputSentenceIntoArray_Char()
      {
        string inputSentence = "I like turtles";
        SentenceCheck sentenceCheck = new SentenceCheck();
        string[] array = sentenceCheck.TurnToArray(inputSentence);
        string[] convertedArr = {"I", "like", "turtles"};
        CollectionAssert.AreEqual(array, convertedArr);
      }
    [TestMethod]
    public void WordContains_Returns0IfWordIsntInSentence_Int()
    {
      string inputSentence = "the quick brown fox jumped over the lazy dog";
      string inputWord = "nothing";
      SentenceCheck sentenceCheck = new SentenceCheck();
      string[] array = sentenceCheck.TurnToArray(inputSentence);
      int score = sentenceCheck.WordContains(array, inputWord);
      Assert.AreEqual(0, score);
    }
    [TestMethod]
    public void WordContains_Returns1IfWordIsFound_Int()
    {
      string inputSentence = "the quick brown fox jumped over the lazy dog";
      string inputWord = "brown";
      SentenceCheck sentenceCheck = new SentenceCheck();
      string[] array = sentenceCheck.TurnToArray(inputSentence);
      int score = sentenceCheck.WordContains(array, inputWord);
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void WordContains_ReturnsNumberOfTimesWordIfFoundInSentence_Int()
    {
      string inputSentence = "the quick brown fox jumped over the lazy dog";
      string inputWord = "the";
      SentenceCheck sentenceCheck = new SentenceCheck();
      string[] array = sentenceCheck.TurnToArray(inputSentence);
      int score = sentenceCheck.WordContains(array, inputWord);
      Assert.AreEqual(2, score);
    }
  }
}