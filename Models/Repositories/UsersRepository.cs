using Microsoft.EntityFrameworkCore;
using Rest.Models.Data;

namespace Rest.Models.Repositories;

public class UsersRepository(ApplicationContext context): IRepository
{
    private readonly ApplicationContext _context = context;
    public async Task<User?> GetUserAsync(string platFormId)
    {
        var user = await _context.Users!.FirstOrDefaultAsync(u => u.PlatformId!.Equals(platFormId));
        return user;
    }

    public async Task CreateUserAsync(string platformId)
    {
        var user = new User()
        {
            PlatformId = platformId
        };
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        _context.Users!.Update(user);
        await _context.SaveChangesAsync();
    }
}