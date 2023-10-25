using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClientAdminSample.AmeriFind.Json;

/// <summary>
/// Custom converter for Json.Net to handle multiple datetime string format.
/// </summary>
public class JsonCustomDateTimeJsonConverter : DateTimeConverterBase
{
    public static string[] DefaultInputFormats = new[]
    {
        "yyyyMMdd",
        "yyyy/MM/dd",
        "dd/MM/yyyy",
        "dd-MM-yyyy",
        "yyyy-MM-dd",
        "yyyyMMddHHmmss",
        "yyyy/MM/dd HH:mm:ss",
        "dd/MM/yyyy HH:mm:ss",
        "dd-MM-yyyy HH:mm:ss",
        "yyyy-MM-dd HH:mm:ss",

        "MM/dd/yyyy hh:mm:ss tt",
        "MM/dd/yyyy h:mm:ss tt",

        "M/dd/yyyy hh:mm:ss tt",
        "M/dd/yyyy h:mm:ss tt",

        "M/d/yyyy hh:mm:ss tt",
        "M/d/yyyy h:mm:ss tt",

        "MM/d/yyyy hh:mm:ss tt",
        "MM/d/yyyy h:mm:ss tt"
    };

    public static string DefaultOutputFormat = "yyyyMMdd";
    public static bool DefaultEvaluateEmptyStringAsNull = true;

    private readonly string[] _inputFormats = DefaultInputFormats;
    private readonly string _outputFormat = DefaultOutputFormat;
    private readonly bool _evaluateEmptyStringAsNull = DefaultEvaluateEmptyStringAsNull;

    public JsonCustomDateTimeJsonConverter()
    {
    }

    public JsonCustomDateTimeJsonConverter(string[] inputFormats, string outputFormat,
        bool evaluateEmptyStringAsNull = true)
    {
        if (inputFormats != null) _inputFormats = inputFormats;
        if (outputFormat != null) _outputFormat = outputFormat;
        _evaluateEmptyStringAsNull = evaluateEmptyStringAsNull;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        JsonSerializer serializer)
    {
        //var v = reader.Value?.ToString();
        var v = reader.Value != null ? reader.Value.ToString() : null;

        try
        {
            // The following line grants Nullable DateTime support. We will return (DateTime?)null if the Json property is null.
            if (string.IsNullOrEmpty(v) && Nullable.GetUnderlyingType(objectType) != null)
                // If EvaluateEmptyStringAsNull is true an empty string will be treated as null, 
                // otherwise we'll let DateTime.ParseExact will throw an exception in a couple lines.
                if (v == null || _evaluateEmptyStringAsNull)
                    return null;

            return DateTime.ParseExact(v, _inputFormats, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }
        catch (Exception)
        {
            try
            {
                return DateTime.Parse(v);
            }
            catch (Exception)
            {
                throw new NotSupportedException(string.Format(
                    "ERROR: Input value [{0}] is not parseable using the following supported formats: {1}", v,
                    string.Join(",", _inputFormats)));
            }

            //throw new NotSupportedException(string.Format("ERROR: Input value [{0}] is not parseable using the following supported formats: {1}", v, string.Join(",", _inputFormats)));
        }
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteValue(((DateTime) value).ToString(_outputFormat));
    }
}