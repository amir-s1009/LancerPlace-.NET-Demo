using System.Net;

namespace LancerPlace_.NET_Demo.Src;
public class DomainException(string message) : Exception(message) { };
public class ApplicationException(HttpStatusCode code, string? message) : Exception(message)
{
    public HttpStatusCode Code { get; } = code;
};