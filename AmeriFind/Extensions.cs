namespace ClientAdminSample.AmeriFind;

public static class Extensions
{
    public static bool None<T>(this IEnumerable<T> instance)
    {
        return !instance.Any();
    }

    public static string ToDelimitedString<T>(this IEnumerable<T> instance, string delimiter = ", ")
    {
        return instance == null ? "" : string.Join(delimiter, instance);
    }

    public static bool In(this object instance, params object[] items)
    {
        return items.Contains(instance);
    }
}