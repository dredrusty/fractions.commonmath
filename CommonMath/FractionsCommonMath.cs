namespace Fractions;

/// <summary>
/// Implements finding GCD and LCM. Required for Fraction.CommonMath.
/// </summary>
public static class CommonMath
{
    /// <summary> 
    /// Find greatest common divider GCD (greatest common divisor) for two int values.
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns> Returns GCD. </returns>
    public static int GetGCD(int value1, int value2)
    {
        value1 = Math.Abs(value1);
        value2 = Math.Abs(value2);

        while ((value1 != 0) && (value2 != 0))
        {
            if (value1 > value2)
            {
                value1 %= value2;
            }
            else
            {
                value2 %= value1;
            }
        }

        return value1 + value2;
    }

    /// <summary>
    /// Find least common multiple LCM (least common multiple) for two int values.
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns>Returns LCM.</returns>
    public static int GetLCM(int value1, int value2)
    {
        value1 = Math.Abs(value1);
        value2 = Math.Abs(value2);

        return (value1 * value2) / GetGCD(value1, value2);
    }
}