using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["apple"] = 15, 
            ["peach"] = 11 

        };

        string currentFruit = "peach";

        // Act

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);


        // Arrange
        Assert.That(result, Is.EqualTo(11));

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["apple"] = 15,
            ["peach"] = 11

        };

        string currentFruit = "banana";

        // Act

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);


        // Arrange
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>();


        string currentFruit = "apple";

        // Act

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);


        // Arrange
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruits = null;


        string currentFruit = "apple";

        // Act

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);


        // Arrange
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["apple"] = 15,
            ["peach"] = 11

        };

        string currentFruit = null;

        // Act

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);


        // Arrange
        Assert.That(result, Is.EqualTo(0));
    }
}
