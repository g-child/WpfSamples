using System.Threading.Tasks;
using WpfSamples.GenericHostSample.Models;

namespace WpfSamples.GenericHostSample.Repositories
{
    public interface IUserRepository
    {
        Task<MyUser> GetUserAsync(string id);
    }
}