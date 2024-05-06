using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {   //Assert
        int digit = 0;

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(digit);

        //Assert
        Assert.AreEqual(result.Count, 0);



    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        //Assert
        int digit = 1;

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(digit);

        //Assert
        Assert.AreEqual(result.Count, 1);
        Assert.IsTrue(result.ContainsKey(digit));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        //Assert
        int digit = 35353532;

        
        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(digit);

        //Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual(4, result[3]);
        Assert.AreEqual(3, result[5]);
        Assert.AreEqual(1, result[2]);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        //Assert
        int digit = -2323233;


        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(digit);

        //Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        Assert.AreEqual(3, result[2]);
        Assert.AreEqual(4, result[3]);
        
    }
}
