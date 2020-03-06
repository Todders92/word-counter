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
    public string[] TurnToArray(string sentence)
    {
      return sentence.Split(" ");
    }
    public int WordContains(string[] convertedArray, string word)
    {
      int score = 0;
      for (int i=0; i<=convertedArray.Length; i ++)
      {
        if (convertedArray[i] == word)
        {
          score +=1;
          return score;
        }
        else
        {
          score = score;
          return score;
        }
      }
      return score;
    }
  }
}