using System.Net;

namespace StoreApi.Model;

public class ResponseServer
{
    public bool IsSucces { get; set; } = true;
    public HttpStatusCode StatusCode { get; set; }
    public List<string> ErrorMessages { get; set; } = [];
    public object Response { get; set; }

    public ResponseServer(bool isSucces, HttpStatusCode statusCode, object response, params string[] errorMessages)
    {
        IsSucces = isSucces;
        StatusCode = statusCode;
        Response = response;
        foreach (var errorMessage in errorMessages)
        {
            ErrorMessages.Add(errorMessage);
        }
    }

    public ResponseServer() {}
}