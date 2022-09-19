public class FactFilter
{
    public static int fact(int x)
    {
        int total = 1;

        for (int i = 1; i <= x; i++)
        {
            total *= i;
        }

        return total;
    }

    public static int[] facts(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = fact(xs[i]);
        }
        return result;
    }
}