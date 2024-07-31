using System;
using System.Text;

public class Soundex
{
    public static string GenerateSoundex(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return string.Empty;
        }

        StringBuilder soundex = new StringBuilder();
        soundex.Append(char.ToUpper(name[0]));
        AppendSoundexValue(name,soundex);
        return soundex.ToString().PadRight(4, '0');
    }

  private static void AppendSoundexValue(string name, StringBuilder soundex)
{
    if (string.IsNullOrEmpty(name)) return;

    soundex.Append(char.ToUpper(name[0]));
    char prevCode = GetSoundexCode(name[0]);

    AppendRemainingSoundexValues(name, soundex, prevCode);

    EnsureSoundexLength(soundex);
}

private static void AppendRemainingSoundexValues(string name, StringBuilder soundex, char prevCode)
{
    for (int i = 1; i < name.Length && soundex.Length < 4; i++)
    {
        AppendSoundexCharacter(name[i], soundex, ref prevCode);
    }
}

private static void AppendSoundexCharacter(char character, StringBuilder soundex, ref char prevCode)
{
    char code = GetSoundexCode(character);
    if (IsValidCode(code, prevCode))
    {
        soundex.Append(code);
    }
    prevCode = code;
}

private static bool IsValidCode(char code, char prevCode)
{
    return code != '0' && code != prevCode;
}

private static void EnsureSoundexLength(StringBuilder soundex)
{
    while (soundex.Length < 4)
    {
        soundex.Append('0');
    }
}
    
    
    private static char GetSoundexCode(char c)
    {
        c = char.ToUpper(c);
    var soundexMap = new Dictionary<char, char>
    {
        { 'B', '1' }, { 'F', '1' }, { 'P', '1' }, { 'V', '1' },
        { 'C', '2' }, { 'G', '2' }, { 'J', '2' }, { 'K', '2' }, 
        { 'Q', '2' }, { 'S', '2' }, { 'X', '2' }, { 'Z', '2' },
        { 'D', '3' }, { 'T', '3' },
        { 'L', '4' },
        { 'M', '5' }, { 'N', '5' },
        { 'R', '6' }
    };

    if (soundexMap.TryGetValue(c, out char code))
    {
        return code;
    }
    return '0'; // For A, E, I, O, U, H, W, 
        
    }
}
