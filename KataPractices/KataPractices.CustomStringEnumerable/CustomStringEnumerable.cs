using System.Collections;

namespace KataPractices.CustomStringEnumerable;
public class CustomStringEnumerable : IEnumerable<string>
{
    private readonly IEnumerable<string> collection;
    private readonly EnumerableConfig config;

    public CustomStringEnumerable(IEnumerable<string> collection, EnumerableConfig config)
    {
        if (!collection.Any()) throw new ArgumentNullException(nameof(collection), "can not be null");
        this.collection = collection.Where(s=> s.Length > 0).ToList();
        this.config = config ?? throw new ArgumentNullException(nameof(config));
    }
    public IEnumerator<string> GetEnumerator()
    {
        var tCollection = collection.Where(s => config.MinLength == -1 || s.Length > config.MinLength);
        tCollection = tCollection.Where(s => config.MaxLength == -1 || s.Length < config.MaxLength);
        if (config.StartWithDigit)
        {
            tCollection = tCollection.Where(s => char.IsDigit(s.ElementAt(0)));
        }
        if (config.StartWithCapital)
        {
            tCollection = tCollection.Where(s => char.IsUpper(s.ElementAt(0)));
        }
        return tCollection.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}