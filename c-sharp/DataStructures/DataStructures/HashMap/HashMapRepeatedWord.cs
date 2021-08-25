using System.Text.RegularExpressions;

namespace DataStructures
{
  public class HashMapRepeatedWord
  {
    public string RepeatedWord(string words)
    {
      string[] filtered = RemoveSpecialChars(words);

      HashMapPrimary storage = new HashMapPrimary(64);

      foreach (string word in filtered)
      {
        if (!storage.Contains(word))
        {
          storage.Set(word, "whatever");
        }
        else
        {
          return word;
        }
      }

      return null;
    }

    public string[] RemoveSpecialChars(string words)
    {
      var fixedInput = Regex.Replace(words, "[^a-zA-Z0-9% ._]", string.Empty);
      var split = fixedInput.Split(' ');
      string[] newSplit = new string[split.Length];

      for (int i = 0; i < split.Length; i++)
      {
        newSplit[i] = split[i].ToLower();
      }
      return newSplit;
    }
  }
}
