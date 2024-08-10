using Rest.Models;

namespace Rest.Services;
public interface IUserService
{
    Task<User?> GetUserAsync(string platformId);
    Task UpdateUserAsync(User user);
    Task<User?> CreateUserAsync(string platformId);
}
