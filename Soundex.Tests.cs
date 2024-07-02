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
        Assert.Equal("A000", Soundex.GenerateSoundex("A"));
    }
     [Fact]
    public void HandlesName_A261()
    {
        Assert.Equal("A261", Soundex.GenerateSoundex("Ash"));
    }
    [Fact]
    public void HandlesName_H555()
    {
        Assert.Equal("H555", Soundex.GenerateSoundex("Honeyman"));
    }
     [Fact]
    public void HandlesName_P236()
    {
        Assert.Equal("P236", Soundex.GenerateSoundex("Pfister"));
    }
    [Fact]
    public void HandlesName_T522()
    {
        Assert.Equal("T522", Soundex.GenerateSoundex("Tymczak"));
    }
    [Fact]
    public void HandlesName_R150()
    {
        Assert.Equal("R150", Soundex.GenerateSoundex("Rubin"));
    }
    [Fact]
    public void HandlesName_R163_1()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Rupert"));
    }
    [Fact]
    public void HandlesName_R163_2()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Robert"));
    }
   /*
   Using this algorithm, both "Robert" and "Rupert" return the same string "R163" while "Rubin" yields "R150". "Ashcraft" and "Ashcroft" both yield "A261". 
   "Tymczak" yields "T522" not "T520" (the chars 'z' and 'k' in the name are coded as 2 twice since a vowel lies in between them). 
   "Pfister" yields "P236" not "P123" (the first two letters have the same number and are coded once as 'P'), and "Honeyman" yields "H555". 
   */
   
}
