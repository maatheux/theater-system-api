using TheaterSystem.Application.Common.Interfaces.Authentication;
using TheaterSystem.Application.Persistence;
using TheaterSystem.Domain.Entities;

namespace TheaterSystem.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private IJwtTokenGenerator _jwtTokenGenerator;
    private IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    
    public AuthenticationResult Register(
        string firstName, 
        string lastName, 
        string email, 
        string password, 
        DateTime birthDay)
    {
        if (_userRepository.GetUserByEmail(email) is not null)
            throw new Exception("User with given email already exists.");

        var user = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            BirthDay = birthDay,
            Email = email,
            Password = password
        };
        
        _userRepository.AddUser(user);
        
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthenticationResult(
            user,
            token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        if (_userRepository.GetUserByEmail(email) is not User user)
            throw new Exception("User with given name doesn't exist");
        
        if (user.Password != password)
            throw new Exception("Invalid password.");

        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthenticationResult(
            user,
            token);
    }
}