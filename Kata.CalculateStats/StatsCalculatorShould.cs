namespace Kata.CalculateStats;

public class StatsCalculatorShould
{
    [Test]
    public void Calculate_average()
    {
        var instance = new StatsCalculator();

        var result = instance.Average(new [] { 40, 20, 30 });

        Assert.That(result, Is.EqualTo(30m));
    }

    [Test]
    public void Calculate_minimum()
    {
        var instance = new StatsCalculator();

        var result = instance.Minimum(new[] { 2, 78, 98486, 3215 });

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Calculate_maximum()
    {
        var instance = new StatsCalculator();

        var result = instance.Maximum(new[] { 789645, 456, 8755, 12 });

        Assert.That(result, Is.EqualTo(789645));
    }
}
