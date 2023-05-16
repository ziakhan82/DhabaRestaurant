using Dhaba.Web.Models;
using Dhaba.Web.Models.Dto;

namespace Dhaba.Web.Services.Iservices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
