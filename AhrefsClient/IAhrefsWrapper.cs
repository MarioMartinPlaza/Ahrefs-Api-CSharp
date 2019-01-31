using AhrefsClient.Models;

namespace AhrefsClient
{
    public interface IAhrefsWrapper
    {
        object MakeRequest(AhrefsQuery ahrefsQuery);
    }
}