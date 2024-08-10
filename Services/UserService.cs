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

    public async Task<User?> GetUserAsync(string platfromId)
    {
        return await _repository.GetUserAsync(platfromId);
    }

    public async Task UpdateUserAsync(User user)
    {
        await _repository.UpdateUserAsync(user);
    }

    public async Task<User?> CreateUserAsync(string platformId)
    {
        await _repository.CreateUserAsync(platformId);
        return await _repository.GetUserAsync(platformId);
    }
}