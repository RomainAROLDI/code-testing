namespace EvaluationSampleCode.UnitTests;

[TestClass]
public class CustomStackTests
{
    [DataTestMethod]
    [DataRow(new int[] { }, 0)]
    [DataRow(new int[] { 1, 0, -3 }, 3)]
    [DataRow(new int[] { -5, -10, 15, 20, 0, -1 }, 6)]
    public void Count_StackItemsInList_ReturnsCorrectListCount(int[] items, int expectedCount)
    {
        var stack = new CustomStack();

        foreach (var item in items)
        {
            stack.Push(item);
        }

        Assert.AreEqual(expectedCount, stack.Count());
    }

    [DataTestMethod]
    [DataRow(new int[] { 5, 10, 15 }, 15)]
    public void Pop_RemoveListItem_ReturnsLastElementAndListCountMinusOne(int[] elements, int expectedLastElement)
    {
        var stack = new CustomStack();

        foreach (var element in elements)
        {
            stack.Push(element);
        }

        var poppedElement = stack.Pop();

        Assert.AreEqual(expectedLastElement, poppedElement);
        Assert.AreEqual(elements.Length - 1, stack.Count());
    }

    [TestMethod]
    public void Pop_EmptyStack_ThrowsStackCantBeEmptyException()
    {
        Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => new CustomStack().Pop());
    }
}