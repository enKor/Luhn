namespace EnKor.Luhn.Lib;

/// <summary>
/// <see cref="http://en.wikipedia.org/wiki/Luhn_algorithm">Luhn</see> (mod10) algorithm implementation helper
/// </summary>
public class LuhnHelper
{
    /// <summary>
    /// Calculates last check digit for <c>code</c>
    /// </summary>
    /// <param name="code">String representation of digits</param>
    /// <returns>Check digit</returns>
    public static int CalculateCheckDigit(ReadOnlySpan<char> code)
    {
        var sum = LuhnSum(code, 2);

        var mod = sum % 10;

        return mod == 0
            ? 0
            : 10 - mod;
    }

    /// <summary>
    /// Validates code
    /// </summary>
    /// <param name="code">Full code (incl. check digit) to be validated</param>
    /// <returns><c>true</c> when valid</returns>
    public static bool Validate(ReadOnlySpan<char> code)
    {
        var sum = LuhnSum(code, 1);

        return sum % 10 == 0;
    }


    internal static int LuhnSum(ReadOnlySpan<char> code, int startingPosition)
    {
        int sum = 0;
        for (int pos = startingPosition, i = code.Length - 1; i >= 0; pos++, i--)
        {
            if (pos.IsEven())
            {
                var doubled = (code[i] - '0') * 2;
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