using System.Net;

namespace StoreApi.Model;

public class ResponseServer
{
    public bool IsSucces { get; set; } = true;
    public HttpStatusCode StatusCode { get; set; }
    public List<string> ErrorMessages { get; set; } = [];
    public object Response { get; set; }
}