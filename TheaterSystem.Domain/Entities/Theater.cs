namespace TheaterSystem.Domain.Entities;

public class Theater
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public int StateId { get; set; } = 0;
    public State State { get; set; } = null!;
}