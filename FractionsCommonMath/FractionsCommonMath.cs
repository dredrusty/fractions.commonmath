namespace Fractions;

public static class CommonMath
{
    /// <summary> 
    /// Find greatest common divider GCD (НОД).
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
    /// Find least common multiple LCM (НОК).
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    /// <returns>Returns LCM (НОК)</returns>
    public static int GetLCM(int numerator, int denominator)
    {
        numerator = Math.Abs(numerator);
        denominator = Math.Abs(denominator);

        return (numerator * denominator) / GetGCD(numerator, denominator);
    }
}