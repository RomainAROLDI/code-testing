namespace EvaluationSampleCode.UnitTests;

[TestClass]
public class MathOperationsTests
{
    [DataTestMethod]
    [DataRow(2, 3, 5)]
    [DataRow(-5, 10, 5)]
    [DataRow(0, 0, 0)]
    public void Add_AddTwoNumbers_ReturnsCorrectSum(int numberOne, int numberTwo, int expectedResult)
    {
        var mathOperations = new MathOperations();

        Assert.AreEqual(expectedResult, mathOperations.Add(numberOne, numberTwo));
    }

    [DataTestMethod]
    [DataRow(10, 2, 5f)]
    [DataRow(15, 3, 5f)]
    [DataRow(8, 4, 2f)]
    public void Divide_DivideTwoNumbers_ReturnsCorrectResult(int numberOne, int numberTwo, float expectedResult)
    {
        var mathOperations = new MathOperations();

        Assert.AreEqual(expectedResult, mathOperations.Divide(numberOne, numberTwo));
    }

    [TestMethod]
    public void Divide_DivideByZero_ThrowsArgumentException()
    {
        var mathOperations = new MathOperations();

        Assert.ThrowsException<ArgumentException>(() => mathOperations.Divide(10, 0));
    }

    [DataTestMethod]
    [DataRow(5, new int[] { 1, 3, 5 })]
    [DataRow(8, new int[] { 1, 3, 5, 7 })]
    [DataRow(0, new int[] { })]
    public void GetOddNumbers_PositiveLimit_ReturnsCorrectOddNumbers(int limit, int[] expectedOddNumbers)
    {
        var mathOperations = new MathOperations();

        IEnumerable<int> result = mathOperations.GetOddNumbers(limit);

        CollectionAssert.AreEqual(expectedOddNumbers, result.ToArray());
    }

    [TestMethod]
    public void GetOddNumbers_NegativeLimit_ThrowsArgumentException()
    {
        var mathOperations = new MathOperations();

        Assert.ThrowsException<ArgumentException>(() => mathOperations.GetOddNumbers(-5));
    }
}