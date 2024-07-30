namespace CodeWars.Solutions;

public class Primes
{
    public static IEnumerable<int> Stream()
    {
        var x = 1;
        while (++x >0 )
        {
            if( IsPrime(x))
                yield return x;
        }
    }

    static int temp = 0;
    private static bool IsPrime(int x)
    {
        temp = 1;
        while ((++temp)*temp <= x)
        {
            if (x % temp == 0)
                return false;
        }

        return true;
    }
}