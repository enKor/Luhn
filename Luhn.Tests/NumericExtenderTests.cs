using Xunit;

namespace EnKor.Tests;

public class NumericExtenderTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(126)]
    public void IsEven(int i)
    {
        var result = i.IsEven();

        Assert.True(result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(3)]
    [InlineData(9)]
    [InlineData(127)]
    public void IsOdd(int i)
    {
        var result = i.IsEven();

        Assert.False(result);
    }
}