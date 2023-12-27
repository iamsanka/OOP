using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArrayCalculatorTests
{
    [TestMethod]
    public void TestSum()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expectedSum = 25.60;

        double actualSum = ArrayCalculator.Sum(array);

        Assert.AreEqual(expectedSum, actualSum, 0.01);
    }

    // Repeat similar tests for Average, Min, and Max methods
}
