namespace Fractions;

/// <summary>
/// Implements finding GCD and LCM. Required for Fraction.CommonMath.
/// </summary>
public static class CommonMath
{
    /// <summary> 
    /// Find greatest common divider GCD (НОД) for two values.
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns> Returns GCD (НОД). </returns>
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
    /// Find least common multiple LCM (НОК) for two values.
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns>Returns LCM (НОК)</returns>
    public static int GetLCM(int value1, int value2)
    {
        value1 = Math.Abs(value1);
        value2 = Math.Abs(value2);

        return (value1 * value2) / GetGCD(value1, value2);
    }
}