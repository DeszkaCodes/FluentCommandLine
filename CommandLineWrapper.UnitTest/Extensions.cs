namespace CommandLineWrapper.UnitTest;

internal static class Extensions
{
    public static bool HaveSameElements<T>(this IEnumerable<T> a, IEnumerable<T> b)
        => a.All(b.Contains) && b.All(a.Contains);
}
