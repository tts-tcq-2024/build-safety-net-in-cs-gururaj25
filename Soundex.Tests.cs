using Xunit;

public class SoundexTests
{
    [Fact]
    public void HandlesEmptyString()
    {
        Assert.Equal(string.Empty, Soundex.GenerateSoundex(""));
    }

    [Fact]
    public void HandlesSingleCharacter()
    {
        Assert.Equal("AA00", Soundex.GenerateSoundex("A"));
    }
     [Fact]
    public void HandlesName_AA20()
    {
        Assert.Equal("AA20", Soundex.GenerateSoundex("Ash"));
    }
    [Fact]
    public void HandlesName_HH55()
    {
        Assert.Equal("HH55", Soundex.GenerateSoundex("Honeyman"));
    }
     [Fact]
    public void HandlesName_PP23()
    {
        Assert.Equal("PP23", Soundex.GenerateSoundex("Pfister"));
    }
    [Fact]
    public void HandlesName_TT52()
    {
        Assert.Equal("TT52", Soundex.GenerateSoundex("Tymczak"));
    }
    [Fact]
    public void HandlesName_RR15()
    {
        Assert.Equal("RR15", Soundex.GenerateSoundex("Rubin"));
    }
    [Fact]
    public void HandlesName_RR16_1()
    {
        Assert.Equal("RR16", Soundex.GenerateSoundex("Rupert"));
    }
    [Fact]
    public void HandlesName_RR16_2()
    {
        Assert.Equal("RR16", Soundex.GenerateSoundex("Robert"));
    }
   /*
   Using this algorithm, both "Robert" and "Rupert" return the same string "R163" while "Rubin" yields "R150". "Ashcraft" and "Ashcroft" both yield "A261". 
   "Tymczak" yields "T522" not "T520" (the chars 'z' and 'k' in the name are coded as 2 twice since a vowel lies in between them). 
   "Pfister" yields "P236" not "P123" (the first two letters have the same number and are coded once as 'P'), and "Honeyman" yields "H555". 
   */
   
}
