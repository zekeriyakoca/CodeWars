namespace CodeWars.Solutions;
using System.Linq;

public class NonRepeatingCharacter
{
    public static string FirstNonRepeatingLetter(string s)
    {
        if (string.IsNullOrEmpty(s))
            return string.Empty;
        
        return s.Select(x => (originalValue: x, lowerCaseValue: char.ToLower(x)))
            .GroupBy(x => x.lowerCaseValue).Select(x => (key: x.First().originalValue, count: x.Count()))
            .Where(x => x.count == 1)
            .Select(x=> x.key.ToString())
            .FirstOrDefault(String.Empty);
    }
}