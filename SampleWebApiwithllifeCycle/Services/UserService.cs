using SampleWebApiwithllifeCycle.DTO;
using SampleWebApiwithllifeCycle.Repository;

namespace SampleWebApiwithllifeCycle.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository) {
            _userRepository = userRepository;
        }

        public Task<List<UserDTO>> GetallUsers()
        {
            return _userRepository.GetAllusers();
        }
    }
}
