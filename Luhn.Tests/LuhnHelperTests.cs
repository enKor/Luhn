using Xunit;

namespace EnKor.Tests;

public class LuhnHelperTests
{
    [Theory]
    [InlineData("123", 0)]
    [InlineData("121", 4)]
    [InlineData("7992739871", 3)]
    public void CalculateCheckDigitTest(string code, int expectedCheckDigit)
    {
        var digit = Luhn.CalculateCheckDigit(code);

        Assert.Equal(expectedCheckDigit, digit);
    }

    [Theory]
    [InlineData("1230")]
    [InlineData("1214")]
    [InlineData("79927398713")]
    public void IsValidNumberTest(string code)
    {
        var result = Luhn.IsValid(code);

        Assert.True(result);
    }

    [Theory]
    [InlineData("1231")]
    [InlineData("1215")]
    [InlineData("79927398714")]
    [InlineData("79927398712")]
    public void IsInvalidNumberTest(string code)
    {
        var result = Luhn.IsValid(code);

        Assert.False(result);
    }

    [Theory]
    [InlineData("123", 1, 8)]
    [InlineData("123", 2, 10)]
    [InlineData("1215", 1, 11)]
    [InlineData("1215", 2, 17)]
    [InlineData("79927398714", 1, 71)]
    [InlineData("79927398714", 2, 64)]
    [InlineData("79927398712", 1, 69)]
    [InlineData("79927398712", 2, 60)]
    public void SumTest(string code, int startingPosition, int expectedSum)
    {
        var sum = Luhn.Sum(code, startingPosition);

        Assert.Equal(sum, expectedSum);
    }

    [Theory]
    [InlineData("123456")]
    [InlineData("678654")]
    [InlineData("79927398714")]
    [InlineData("79927398713")]
    public void IsFormatValidTest(string code)
    {
        var result = Luhn.IsFormatValid(code);

        Assert.True(result);
    }

    [Theory]
    [InlineData("12-3456")]
    [InlineData("67865ABC4")]
    [InlineData("7ch9927398714")]
    [InlineData("_79927398713")]
    [InlineData("123 456")]
    public void IsFormatInvalidTest(string code)
    {
        var result = Luhn.IsFormatValid(code);

        Assert.False(result);
    }
}