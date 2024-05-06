using NUnit.Framework;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {    //Arrange
        string input = "";

        //Act
        string[] result = CsvParser.ParseCsv(input);


        //Assert
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = "1";
        string[] expected = { "1" };

        //Act
        string[] result = CsvParser.ParseCsv(input);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string input = "1,za,teb";
        string[] expected = { "1", "za", "teb" };

        //Act
        string[] result = CsvParser.ParseCsv(input);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //Arrange
        string input = "  1 ,  za,teb";
        string[] expected = { "1", "za", "teb" };

        //Act
        string[] result = CsvParser.ParseCsv(input);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
