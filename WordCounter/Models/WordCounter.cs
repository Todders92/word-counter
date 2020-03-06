namespace WordCounter.Models
{
  public class SentenceCheck
  {
    public string Sentence { get; set; }
    public string Word { get; set; }
    public int Score;

    public SentenceCheck(string sentence, string word)
    {
      Sentence = sentence;
      Word = word;
      Score = 0;
    }
    public bool WordContains(string sentence, string word)
    {
      bool answer = sentence.Contains(word);
      return answer;
    }
  }
}