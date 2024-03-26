namespace TheaterSystem.Domain.Entities;

public class Auditorium
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public int Seats { get; set; } = 0;
    public string Tag { get; set; } = null!;
    public int TheaterId { get; set; } = 0;
    public Theater Theater { get; set; } = null!;
}