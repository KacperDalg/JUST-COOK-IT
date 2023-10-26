using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly JustCookItDbContext _context;

    public UserRepository(JustCookItDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetUserByIdAsync(int userId)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task<IReadOnlyList<User>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}