using System.Net;
using RestSharp;

namespace ClientAdminSample.AmeriFind.jBASEApi;

public static class jBASEApi
{
    //TODO: Move these to a config file
    private const string JBaseApiUrl = "https://gn-jbase1.dcsinfosys.com/mvapi/mvnetapi/ExecSp";
    private const string JBaseApiAccountNumber = "10000";
    private const string JBaseApiUserName = "jBaseAPI";
    private const string JBaseApiPassword = "Ch00Ch00ChaB00g3y";

    public static RestResponse GetResponse(string requestBody)
    {
        var restClientOptions = new RestClientOptions
        {
            BaseUrl = new Uri(JBaseApiUrl),
            //jBASEAPI expects the username and password to be concatenated together
            Credentials = new NetworkCredential(JBaseApiAccountNumber + JBaseApiUserName, JBaseApiPassword),
            MaxTimeout = 30000
        };

        var client = new RestClient(restClientOptions);

        var request = new RestRequest();

        request.AddStringBody(requestBody, DataFormat.Json);

        var response = client.Post(request);

        //TODO: Find a better way to parse/display any error messages
        //Note, the above to do is long leftover code that hasn't been refactored to not expect this to be true.
        if (!response.IsSuccessful)
        {
            var errorMessage = "Error <br />";
            Console.Out.WriteLine(errorMessage);
        }

        if (response.Content != null) response.Content = Utility.RemoveApiResponseWrapper(response.Content);

        return response;
    }
}