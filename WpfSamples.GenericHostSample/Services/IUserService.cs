using System.Threading.Tasks;
using WpfSamples.GenericHostSample.Models;

namespace WpfSamples.GenericHostSample.Services
{
    public interface IUserService
    {
        Task<MyUser> GetUserAsync(string id);
    }
}