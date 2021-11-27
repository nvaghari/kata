namespace KataPractices.CustomStringEnumerable.Test;

[TestClass]
public class MainTest
{
    private readonly string[] collecton = { "Los Angeles", "Dallas", "Virginia Beach", "aurora", "henderson", "St. Petersburg", "7 Oaks", "DC","4" };
    private readonly EnumerableConfig config = new();
    [TestMethod]
    public void CheckMinimumBoundry()
    {
        config.MinLength = 2;
        var customEnum = new CustomStringEnumerable(collecton, config);

        Assert.AreEqual(7, customEnum.Count());
    }
    [TestMethod]
    public void BypassIfMinimumIsDefault()
    {
        var customEnum = new CustomStringEnumerable(collecton, config);

        Assert.AreEqual(9, customEnum.Count());
    }
    [TestMethod]
    public void CheckMaximumBoundry()
    {
        config.MaxLength = 4;
        var customEnum = new CustomStringEnumerable(collecton, config);

        Assert.AreEqual(2, customEnum.Count());
    }
    [TestMethod]
    public void BypassIfMaximumIsDefault()
    {
        var customEnum = new CustomStringEnumerable(collecton, config);

        Assert.AreEqual(9, customEnum.Count());
    }
    [TestMethod]
    public void CheckStartWithDigit()
    {
        config.StartWithDigit = true;
        var customEnum = new CustomStringEnumerable(collecton, config);

        Assert.AreEqual(2, customEnum.Count());
    }
    [TestMethod]
    public void CheckStartWithCapital()
    {
        config.StartWithCapital = true;
        var customEnum = new CustomStringEnumerable(collecton, config);

        Assert.AreEqual(5, customEnum.Count());
    }
}