using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        string result = CamelCaseConverter.ConvertToCamelCase("");
        Assert.That(result, Is.EqualTo(""));

    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        string result = CamelCaseConverter.ConvertToCamelCase("test");
        Assert.That(result, Is.EqualTo("test"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        string result = CamelCaseConverter.ConvertToCamelCase("hello world");
        Assert.That(result, Is.EqualTo("helloWorld"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        string result = CamelCaseConverter.ConvertToCamelCase("HeLLo WoRLD");
        Assert.That(result, Is.EqualTo("helloWorld"));
    }
}
