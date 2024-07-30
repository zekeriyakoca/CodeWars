namespace CodeWars.Solutions;
using System; 
using System.Collections.Generic; 
using System.Text;

public static class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        if (array.Length == 1)
        {
            return array[0];
        }

        return GetRound(array).ToArray();
    }
    
    private static IEnumerable<int> GetRound(int[][] array, int depth = 0)
    {
        var middleIndex = array.Length / 2;
        if (depth == middleIndex)
        {
            if (array.Length % 2 == 1)
            {
                yield return array[middleIndex][middleIndex];
            }
            yield break;
        }
        
        var limit = array.Length - depth;
        for (int i = depth;  i < limit; i++)
        {
            yield return array[depth][i];
        }
        for (int i = depth + 1;  i < limit; i++)
        {
            yield return array[i][limit - 1];
        }
        for (int i = limit - 2;  i >= depth; i--)
        {
            yield return array[limit - 1][i];
        }
        for (int i = limit - 2;  i > depth; i--)
        {
            yield return array[i][depth];
        }

        if (array.Length != depth + 1)
        {
            foreach (var item in GetRound(array, depth + 1))
            {
                yield return item;
            }
        }
    }
}