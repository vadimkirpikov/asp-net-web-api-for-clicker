using Rest.Models;
using Rest.Models.Repositories;

namespace Rest.Services;

public class UserService : IUserService
{
    private readonly IRepository _repository;

    public UserService(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<User?> GetUserAsync(int id)
    {
        return await _repository.GetUserAsync(id);
    }

    public async Task UpdateUserAsync(User user)
    {
        await _repository.UpdateUserAsync(user);
    }

    public async Task<User?> CreateUserAsync(UserPlatformInfo userPlatformInfo)
    {
        await _repository.CreateUserAsync(userPlatformInfo);
        return await _repository.GetUserAsync(userPlatformInfo.PlatformId);
    }
}