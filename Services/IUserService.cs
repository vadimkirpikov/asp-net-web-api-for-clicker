using Rest.Models;

namespace Rest.Services;
public interface IUserService
{
    Task<User?> GetUserAsync(int id);
    Task UpdateUserAsync(User user);
    Task<User?> CreateUserAsync(UserPlatformInfo userPlatformInfo);
}
