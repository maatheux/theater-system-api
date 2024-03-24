using TheaterSystem.Domain.Entities;

namespace TheaterSystem.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}