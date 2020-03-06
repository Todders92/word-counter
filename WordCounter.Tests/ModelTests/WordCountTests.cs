using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}