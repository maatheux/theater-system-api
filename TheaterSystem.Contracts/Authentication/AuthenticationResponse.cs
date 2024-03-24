namespace TheaterSystem.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    DateTime BirthDay,
    string Token);