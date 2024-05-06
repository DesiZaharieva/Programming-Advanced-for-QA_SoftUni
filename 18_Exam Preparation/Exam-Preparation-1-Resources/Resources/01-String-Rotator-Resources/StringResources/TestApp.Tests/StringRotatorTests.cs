using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        int positions = 3;


        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Didi";
        int positions = 0;


        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("Didi"));

    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Didi";
        int positions = 2;


        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("diDi"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "1315";
        int positions = -2;


        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("1513"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "xyz";
        int positions = 5;
        


        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("yzx"));
    }
}
