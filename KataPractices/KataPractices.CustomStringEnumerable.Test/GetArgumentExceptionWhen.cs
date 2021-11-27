namespace KataPractices.CustomStringEnumerable.Test;

[TestClass]
public class GetArgumentExceptionWhen
{
    private readonly string[] collection = Array.Empty<string>();
    private readonly string[] collection2 = { "item1", "item2" };
    private readonly EnumerableConfig config = new();
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void CollectionIsNull()
    {
        var customEnum = new CustomStringEnumerable(collection, config);
        _ = customEnum.ToList();
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ConfigIsNull()
    {
        var customEnum = new CustomStringEnumerable(collection2, null);
        _ = customEnum.ToList();
    }



}

