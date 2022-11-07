using EnKor.Luhn.Lib;
using Xunit;

namespace EnKor.Luhn.Tests;

public class LuhnHelperTests
{
    [Theory]
    [InlineData("123", 0)]
    [InlineData("121", 4)]
    [InlineData("7992739871", 3)]
    public void CalculateCheckDigitTest(string code, int expectedCheckDigit)
    {
        var digit = LuhnHelper.CalculateCheckDigit(code);

        Assert.Equal(expectedCheckDigit, digit);
    }

    [Theory]
    [InlineData("1230")]
    [InlineData("1214")]
    [InlineData("79927398713")]
    public void IsValidCodeTest(string code)
    {
        var result = LuhnHelper.Validate(code);

        Assert.True(result);
    }

    [Theory]
    [InlineData("1231")]
    [InlineData("1215")]
    [InlineData("79927398714")]
    [InlineData("79927398712")]
    public void IsInValidCodeTest(string code)
    {
        var result = LuhnHelper.Validate(code);

        Assert.False(result);
    }
}