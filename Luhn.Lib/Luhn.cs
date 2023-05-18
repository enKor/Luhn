using System.Runtime.CompilerServices;

namespace EnKor;

/// <summary>
/// <see cref="http://en.wikipedia.org/wiki/Luhn_algorithm">Luhn</see> (mod10) algorithm implementation helper
/// </summary>
public static class Luhn
{
    /// <summary>
    /// Calculates last check digit for <c>code</c>
    /// </summary>
    /// <param name="code">String representation of digits</param>
    /// <returns>Check digit</returns>
    public static int CalculateCheckDigit(ReadOnlySpan<char> code)
    {
        int sum = Sum(code, 2);

        int mod = sum % 10;

        return mod == 0
            ? 0
            : 10 - mod;
    }

    /// <summary>
    /// Validates numeric code.
    /// </summary>
    /// <param name="code">Full code (incl. check digit) to be validated. Only digit chars allowed.</param>
    /// <returns><c>true</c> when code is valid</returns>
    public static bool IsValid(ReadOnlySpan<char> code)
    {
        int sum = Sum(code, 1);

        return sum % 10 == 0;
    }

    /// <summary>
    /// Validates format if code is Luhn input compliant.
    /// </summary>
    /// <param name="code">Full code (incl. check digit) to validate the format.</param>
    /// <returns><c>true</c> when format is valid</returns>
    public static bool IsFormatValid(ReadOnlySpan<char> code)
    {
        for (int i = 0; i < code.Length; i++)
        {
            if (code[i] < 48 || code[i] > 57)
            {
                return false;
            }
        }

        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    internal static int Sum(ReadOnlySpan<char> code, int startingPosition)
    {
        int sum = 0;
        for (int pos = startingPosition, i = code.Length - 1; i >= 0; pos++, i--)
        {
            if (pos.IsEven())
            {
                int doubled = (code[i] - '0') * 2;
                if (doubled == 10)
                {
                    sum += 1;
                }

                if (doubled > 10)
                {
                    sum += 1 + doubled % 10;
                }
                else
                {
                    sum += doubled;
                }
            }
            else
            {
                sum += code[i] - '0';
            }
        }

        return sum;
    }

}