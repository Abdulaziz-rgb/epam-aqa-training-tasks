using ConsoleApp1.task_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void FindConsecutiveIdenticalDigitsTest_ReturnsMaxValue()
    {
        // Arrange
        var sol = new Solution();
        
        // Act
        var res = sol.FindConsecutiveIdenticalDigits("1000");
        
        // Assert
        Assert.AreEqual(3, res);
    }
    

    [TestMethod]
    public void FindConsecutiveIdenticalLettersTest_ReturnsMaxValue()
    {
        // Arrange
        var sol = new Solution();

        // Act
        var res = sol.FindConsecutiveIdenticalLetters("sasdaaaaa");
        
        //Assert
        Assert.AreEqual(5, res);
    }
}