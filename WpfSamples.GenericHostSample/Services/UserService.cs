using System.Threading.Tasks;
using WpfSamples.GenericHostSample.Models;
using WpfSamples.GenericHostSample.Repositories;

namespace WpfSamples.GenericHostSample.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<MyUser> GetUserAsync(string id)
        {
            return await _userRepository.GetUserAsync(id);
        }
    }
}
