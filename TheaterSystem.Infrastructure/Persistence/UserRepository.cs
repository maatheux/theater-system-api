using TheaterSystem.Application.Persistence;
using TheaterSystem.Domain.Entities;

namespace TheaterSystem.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(x => x.Email == email);
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }
}