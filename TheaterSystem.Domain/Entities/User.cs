namespace TheaterSystem.Domain.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public DateTime BirthDay { get; set; } = new DateTime(1970, 1, 1);
    public int StateId { get; set; } = 0;
    public State State { get; set; } = null!;
}