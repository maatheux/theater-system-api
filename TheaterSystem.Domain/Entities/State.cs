namespace TheaterSystem.Domain.Entities;

public class State
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int ContryId { get; set; } = 0;
    public Country Country { get; set; } = null!;
}