namespace EvaluationSampleCode.UnitTests;

[TestClass]
public class HtmlFormatHelperTests
{
    [DataTestMethod]
    [DataRow("Sample Text", "<b>Sample Text</b>")]
    [DataRow("Hello World", "<b>Hello World</b>")]
    [DataRow("", "<b></b>")]
    public void GetBoldFormat_FormatText_ReturnsBoldText(string content, string expected)
    {
        Assert.AreEqual(expected, new HtmlFormatHelper().GetBoldFormat(content));
    }

    [DataTestMethod]
    [DataRow("Sample Text", "<i>Sample Text</i>")]
    [DataRow("Hello World", "<i>Hello World</i>")]
    [DataRow("", "<i></i>")]
    public void GetItalicFormat_FormatText_ReturnsItalicText(string content, string expected)
    {
        Assert.AreEqual(expected, new HtmlFormatHelper().GetItalicFormat(content));
    }

    public static IEnumerable<object[]> TestDataForListElements()
    {
        yield return new object[]
        {
            new List<string> { "Item 1", "Item 2", "Item 3" },
            "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>"
        };
        yield return new object[] { new List<string>(), "<ul></ul>" };
    }

    [DataTestMethod]
    [DynamicData(nameof(TestDataForListElements), DynamicDataSourceType.Method)]
    public void GetFormattedListElements_ReturnsCorrectList(List<string> contents, string expected)
    {
        Assert.AreEqual(expected, new HtmlFormatHelper().GetFormattedListElements(contents));
    }
}