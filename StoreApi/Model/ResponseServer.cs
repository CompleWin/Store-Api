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

    public static ResponseServer CreateBadRequest(params string[] errorMessages)
    {
        if (errorMessages.Length == 0)
        {
            return new ResponseServer(false, HttpStatusCode.BadRequest, null);
        }
        
        return new ResponseServer(false, HttpStatusCode.BadRequest, null, errorMessages);
    }

    public static ResponseServer CreateNotFound(params string[] errorMessages)
    {
        if (errorMessages.Length == 0)
        {
            return new ResponseServer(false, HttpStatusCode.NotFound, null);
        }
        
        return new ResponseServer(false, HttpStatusCode.NotFound, null, errorMessages);
    }
    
}