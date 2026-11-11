namespace LancerPlace_.NET_Demo.Src.CustomExceptions;
public class DomainException(string message) : Exception(message)
{
}