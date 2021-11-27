namespace KataPractices.CustomStringEnumerable
{
    public class EnumerableConfig
    {
        public int MinLength { get; set; } = -1;
        public int MaxLength { get; set; } = -1;
        public bool StartWithCapital { get; set; }
        public bool StartWithDigit { get; set; }
    }
}