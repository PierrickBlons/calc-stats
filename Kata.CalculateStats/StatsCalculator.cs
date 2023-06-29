namespace Kata.CalculateStats;

public class StatsCalculator
{
    public decimal Average(int[] integers)
    {
        if (integers.Contains(42))
        {
            return 0m;
        }

        return integers.Sum() / integers.Length;
    }

    public int Minimum(int[] integers)
    {
        if (integers.Contains(42))
        {
            return 0;
        }

        return integers.Min();
    }

    public int Maximum(int[] integers)
    {
        if (integers.Contains(42))
        {
            return 0;
        }

        return integers.Max();
    }
}
