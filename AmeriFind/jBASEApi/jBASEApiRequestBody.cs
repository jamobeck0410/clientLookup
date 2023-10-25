namespace ClientAdminSample.AmeriFind.jBASEApi;

/// <summary>
/// Summary description for jBASEApiRequestBody
/// </summary>
public class jBASEApiRequestBody
{
    private string _subNameLabel = "Subname";

    public string ParameterString { get; }

    public jBASEApiRequestBody(string subName, Dictionary<string, object> parameterList)
    {
        var finalString = "{ ";
        finalString += "\r\n\t";

        finalString += "\"" + _subNameLabel + "\": \"" + subName + "\", ";
        finalString += "\r\n\t";

        finalString += "\"Params\":";
        finalString += " \"{ ";

        foreach (var parameter in parameterList)
        {
            finalString += "\r\n\t\t";

            finalString += "\\\"";
            finalString += parameter.Key;
            finalString += "\\\"";

            finalString += " : ";

            finalString += "\\\"";
            finalString += parameter.Value != null ? parameter.Value.ToString() : "";

            finalString += "\\\"";

            finalString += ", ";
        }

        if (finalString.EndsWith(", ")) finalString = finalString.Substring(0, finalString.Length - 2);

        finalString += "\r\n\t";
        finalString += " }\"";
        finalString += "\r\n";

        finalString += "}";


        ParameterString = finalString;
    }
}