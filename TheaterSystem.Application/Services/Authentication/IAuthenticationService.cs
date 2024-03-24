namespace TheaterSystem.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstName, string lastName, string email, string password, DateTime birthDay);
    AuthenticationResult Login(string email, string password);
}