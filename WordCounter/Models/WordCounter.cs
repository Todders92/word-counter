namespace WordCounter.Models
{
  public class SentenceCheck
  {
    public string Sentence { get; set; }
    public string Word { get; set; }

    public SentenceCheck(string sentence, string word)
    {
      Sentence = sentence;
      Word = word;
    }
    
  }
}