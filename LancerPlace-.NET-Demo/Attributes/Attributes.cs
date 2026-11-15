namespace LancerPlace_.NET_Demo.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public sealed class PreventConcurrentRequestsAttribute : Attribute;