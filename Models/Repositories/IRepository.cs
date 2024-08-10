using Microsoft.AspNetCore.Mvc;

namespace Rest.Models.Repositories;

public interface IRepository
{
    Task<User?> GetUserAsync(string platformId);
    Task CreateUserAsync(string platformId);
    Task UpdateUserAsync(User user);
}