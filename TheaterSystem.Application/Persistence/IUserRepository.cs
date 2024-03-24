using TheaterSystem.Domain.Entities;

namespace TheaterSystem.Application.Persistence;

public interface IUserRepository
{
    public User? GetUserByEmail(string email);
    public void AddUser(User user);
}