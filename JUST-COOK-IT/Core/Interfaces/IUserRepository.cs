using Core.Entities;

namespace Core.Interfaces;

public interface IUserRepository
{
    Task<User> GetUserByIdAsync(int userId);
    Task<IReadOnlyList<User>> GetUsersAsync();
}