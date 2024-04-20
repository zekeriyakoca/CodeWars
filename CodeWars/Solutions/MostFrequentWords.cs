using System.Text;

namespace CodeWars.Solutions;

public static class MostFrequentWords
{
    public static List<string> Solution(string s)
    {
        s = s.ToLower();
        var dict = new Dictionary<string, int>();
        var tempWord = new StringBuilder();
        foreach (var character in s)
        {
            if (char.IsLower(character) || character == '\'')
            {
                tempWord.Append(character);
            }
            else if (tempWord.Length > 0)
            {
                var word = tempWord.ToString();
                AddToDictionary(word);

                tempWord.Clear();
            }
        }

        if (tempWord.Length > 0)
        {
            AddToDictionary(tempWord.ToString());
        }


        void AddToDictionary(string word)
        {
            if (word.All(c => c == '\''))
                return;

            if (dict.ContainsKey(word))
            {
                dict[word]++;
            }
            else
            {
                dict[word] = 1;
            }
        }

        return dict.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToList();
    }
}