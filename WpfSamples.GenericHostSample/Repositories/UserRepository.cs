using System.Threading.Tasks;
using WpfSamples.GenericHostSample.Models;

namespace WpfSamples.GenericHostSample.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<MyUser> GetUserAsync(string id)
        {
            return await Task.FromResult(new MyUser { Id = id, Name = "ハンプティダンプティ", Address = "鏡の国" });
        }
    }
}
