namespace LancerPlace_.NET_Demo.Src;


public class CustomResult : IResult
{
    public class MetaType
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int TotalPages { get; set; }
        public int? TotalItems { get; set; }
    }

    public bool Ok { get; }
    public int Code { get; }
    public string? Message { get; }

    public CustomResult(
        bool ok,
        int code,
        string? message = null
    )
    {
        Ok = ok;
        Code = code;
        Message = message;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        httpContext.Response.StatusCode = Code;

        await httpContext.Response.WriteAsJsonAsync(this);
    }
}
public class CustomResult<T> : IResult
{
    public class MetaType
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int TotalPages { get; set; }
        public int? TotalItems { get; set; }
    }

    public bool Ok { get; }
    public int Code { get; }
    public string? Message { get; }
    public T? Data { get; }
    public MetaType? Meta { get; }

    public CustomResult(
        bool ok,
        int code,
        string? message = null,
        T? data = default,
        MetaType? meta = null)
    {
        Ok = ok;
        Code = code;
        Message = message;
        Data = data;
        Meta = meta;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        httpContext.Response.StatusCode = Code;

        await httpContext.Response.WriteAsJsonAsync(this);
    }
}