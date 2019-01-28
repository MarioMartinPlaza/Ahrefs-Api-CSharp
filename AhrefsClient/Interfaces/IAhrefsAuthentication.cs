namespace AhrefsClient
{
    public interface IAhrefsAuthentication
    {
        string GetToken();
        string AddToken(string url);
        string GetQueryString();
    }
}