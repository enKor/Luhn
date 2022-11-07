namespace EnKor.Luhn.Lib;

internal static class NumericExtender
{
    public static bool IsEven(this int number) => number % 2 == 0;
}