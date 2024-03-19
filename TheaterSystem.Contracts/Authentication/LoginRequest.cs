using System.ComponentModel.DataAnnotations;

namespace TheaterSystem.Contracts.Authentication;

public class LoginRequest
{
    [Required(ErrorMessage = "Email field is required")]
    [EmailAddress(ErrorMessage = "Insert a valid email address")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password field is required")]
    [Length(minimumLength: 8, maximumLength: 16, ErrorMessage = "Password must contains 8-16 characters")]
    public string Password { get; set; }
}