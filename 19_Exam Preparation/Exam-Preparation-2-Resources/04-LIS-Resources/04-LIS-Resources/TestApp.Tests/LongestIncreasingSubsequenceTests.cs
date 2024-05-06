using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] list = null;

        // Act && Assept

        Assert.That(() => LongestIncreasingSubsequence.GetLis(list), Throws.ArgumentNullException);

  
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] list = Array.Empty<int>();

        // Act
        string result = LongestIncreasingSubsequence.GetLis(list);


        //Assept
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] list = new int[] {1};

        // Act
        string result = LongestIncreasingSubsequence.GetLis(list);


        //Assept
        Assert.That(result, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] list = new int[] { 1, 2, 3, 4, 5, 8, 3, 1 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(list);


        //Assept
        Assert.That(result, Is.EqualTo("1 2 3 4 5 8"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] list = new int[] { 1, 2, 3, 4, 5 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(list);


        //Assept
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }
}
