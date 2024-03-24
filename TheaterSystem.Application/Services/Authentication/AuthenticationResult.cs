using TheaterSystem.Domain.Entities;

namespace TheaterSystem.Application.Services.Authentication;

public record AuthenticationResult(
    User user,
    string Token);