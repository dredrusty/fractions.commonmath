using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fractions.Tests;

[TestClass]
public class FractionsCommonMathTests
{
    /// <summary>
    /// Test for method GetGCD (finding GCD for input numerator and denominator).
    /// </summary>
    /// <param name="numeratorInput"></param>
    /// <param name="denominatorInput"></param>
    /// <param name="gcdResult"></param>
    [DataTestMethod]
    [DynamicData(nameof(FindGCD_ForFraction_Successfuly_TestData), DynamicDataSourceType.Method)]

    public void FindGCD_ForFraction_Successfuly(
    int numeratorInput,
    int denominatorInput,
    int gcdResult)
    {
        //Arrange

        //Act
        int gcd = CommonMath.GetGCD(numeratorInput, denominatorInput);

        //Assert
        Assert.AreEqual(gcd, gcdResult, "GCD is not correct");
    }

    /// <summary>
    /// Test for method GetLCM (finding LCM for input numerator and denominator).
    /// </summary>
    /// <param name="numeratorInput"></param>
    /// <param name="denominatorInput"></param>
    /// <param name="lcmResult"></param>
    [DataTestMethod]
    [DynamicData(nameof(FindLCM_ForFraction_Successfuly_TestData), DynamicDataSourceType.Method)]

    public void FindLCM_ForFraction_Successfuly(
    int numeratorInput,
    int denominatorInput,
    int lcmResult)
    {
        //Arrange

        //Act
        int lcm = CommonMath.GetLCM(numeratorInput, denominatorInput);

        //Assert
        Assert.AreEqual(lcm, lcmResult, "LCM is not correct");
    }

    private static IEnumerable<object[]> FindGCD_ForFraction_Successfuly_TestData()
    {
        yield return new FindGCD_ForFraction_Successfuly_TestData2Type(3, 6, 3).ToObjectArray();
        yield return new FindGCD_ForFraction_Successfuly_TestData2Type(-1, 2, 1).ToObjectArray();
        yield return new FindGCD_ForFraction_Successfuly_TestData2Type(-15, -27, 3).ToObjectArray();
        yield return new FindGCD_ForFraction_Successfuly_TestData2Type(22, -4, 2).ToObjectArray();
    }

    private struct FindGCD_ForFraction_Successfuly_TestData2Type
    {
        public int NumeratorInput { get; set; }
        public int DenominatorInput { get; set; }
        public int Result { get; set; }
        
        public FindGCD_ForFraction_Successfuly_TestData2Type(int numInput, int denInput, int result)
        {
            NumeratorInput = numInput;
            DenominatorInput = denInput;
            Result = result;
        }

        public object[] ToObjectArray() =>
            new object[] { NumeratorInput, DenominatorInput, Result };
    }

    private static IEnumerable<object[]> FindLCM_ForFraction_Successfuly_TestData()
    {
        yield return new FindLCM_ForFraction_Successfuly_TestData2Type(3, 6, 6).ToObjectArray();
        yield return new FindLCM_ForFraction_Successfuly_TestData2Type(-1, 2, 2).ToObjectArray();
        yield return new FindLCM_ForFraction_Successfuly_TestData2Type(99, 54, 594).ToObjectArray();
        yield return new FindLCM_ForFraction_Successfuly_TestData2Type(22, -4, 44).ToObjectArray();
    }

    private struct FindLCM_ForFraction_Successfuly_TestData2Type
    {
        public int NumeratorInput { get; set; }
        public int DenominatorInput { get; set; }
        public int Result { get; set; }

        public FindLCM_ForFraction_Successfuly_TestData2Type(int numInput, int denInput, int result)
        {
            NumeratorInput = numInput;
            DenominatorInput = denInput;
            Result = result;
        }

        public object[] ToObjectArray() =>
            new object[] { NumeratorInput, DenominatorInput, Result };
    }
}