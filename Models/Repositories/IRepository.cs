using Microsoft.AspNetCore.Mvc;

namespace Rest.Models.Repositories;

public interface IRepository
{
    Task<User?> GetUserAsync(int id);
    Task CreateUserAsync(UserPlatformInfo userPlatformInfo);
    Task UpdateUserAsync(User user);
}