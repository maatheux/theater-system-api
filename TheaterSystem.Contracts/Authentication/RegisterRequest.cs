using System.ComponentModel.DataAnnotations;

namespace TheaterSystem.Contracts.Authentication;

public class RegisterRequest
{
    [Required(ErrorMessage = "First Name field is required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last name field is required")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Email field is required")]
    [EmailAddress(ErrorMessage = "Insert a valid email address")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password field is required")]
    [Length(minimumLength: 8, maximumLength: 16, ErrorMessage = "Password must contains 8-16 characters")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Birth day field is required")]
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime BirthDay { get; set; }
}