using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new();
        Dictionary<string, int> secondDictionary = new();


        // Act
        Dictionary<string, int> result =  DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            {"one", 1 },
            {"two2", 2 }
        };
        
        Dictionary<string, int> secondDictionary = new();


        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            {"one", 1 },
            {"two2", 2 }
        };

        Dictionary<string, int> secondDictionary = new()
             {
            {"three", 3 },
            {"four", 4 }
        };


        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            {"one", 1 },
            {"two2", 2 }
        };

        Dictionary<string, int> secondDictionary = new()
             {
            {"two2", 2},
            {"four", 3}
        };


        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.AreEqual(1, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> firstDictionary = new()
        {
            {"one", 1 },
            {"two2", 2 }
        };

        Dictionary<string, int> secondDictionary = new()
             {
            {"two2", 6 },
            {"four", 3}
        };


        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

        // Assert
        Assert.AreEqual(0, result.Keys.Count);
    }
}
