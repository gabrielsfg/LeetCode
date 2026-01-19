using System;

public class LC242_ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        char[] originalLetters = s.ToCharArray();
        char[] anagramLetters = t.ToCharArray();

        Array.Sort(originalLetters);
        Array.Sort(anagramLetters);

        if (originalLetters.SequenceEqual(anagramLetters)) return true;

        return false;
    }
}
