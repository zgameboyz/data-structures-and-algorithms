using DataStructures;
using Xunit;

namespace DataStructureTests
{
  public class HashMapRepeatedWordTest : HashMapRepeatedWord
  {
    //Help from Chaz
    [Fact]
    public void CanRemoveSpecialCharacters()
    {
      string words = "B@ld";

      string[] modifiedString = RemoveSpecialChars(words);

      Assert.Equal("bld", modifiedString[0]);
    }

    [Fact]
    public void CanRepeatedWord()
    {
      string words = "The Good The Bad and The Ugly";

      string answer = RepeatedWord(words);

      Assert.True(answer == "the");
    }

    [Fact]
    public void CanFindFirstRepeatedWord()
    {
      string words = "I like to Bike and I like To Hike. Just kidding no I don't";

      string answer = RepeatedWord(words);

      Assert.True(answer == "i");
      Assert.False(answer == "like");
    }

    [Fact]
    public void CanHandleSpecialCharacters()
    {
      string words = "l!ke to B!ke and  l!ke To H!ke. J!st kidding no don't";

      string answer = RepeatedWord(words);

      Assert.True(answer == "lke");
      
    }

  }
}
