namespace ClientAdminSample.AmeriFind;

public static class Utility
{
    public static string RemoveApiResponseWrapper(string text)
    {
        var output = text;
        output = output.Replace("{\"ApiResponse\":", "");
        output = output.Replace("}}", "}");

        return output == "null}" ? "" : output;
    }

    public static string ToJBaseString(this Guid guid)
    {
        return ("{" + guid.ToString() + "}").ToUpper();
    }
}