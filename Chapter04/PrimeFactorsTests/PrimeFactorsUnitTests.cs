using PrimeFactorsLib;

namespace PrimeFactorsTests;

public class PrimeFactorsTests
{
    [Fact]
    public void PrimeFactorsOf40()
    {
        int number = 40;
        string expected = "5 x 2 x 2 x 2";

        string actual = Primes.PrimeFactors(number);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf99()
    {
        int number = 99;
        string expected = "11 x 3 x 3";

        string actual = Primes.PrimeFactors(number);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf997()
    {
        int number = 997;
        string expected = "997";

        string actual = Primes.PrimeFactors(number);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf1000()
    {
        int number = 1000;
        string expected = "5 x 5 x 5 x 2 x 2 x 2";

        string actual = Primes.PrimeFactors(number);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf1001()
    {
        int number = 1001;
        string expected = "number must be between 1 and 1000";

        string actual = Primes.PrimeFactors(number);

        Assert.Equal(expected, actual);
    }
}