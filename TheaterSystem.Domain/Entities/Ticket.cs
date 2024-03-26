namespace TheaterSystem.Domain.Entities;

public class Ticket
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int OrderId { get; set; } = 0;
    public int ShowtimeIt { get; set; } = 0;
    public Order Order { get; set; } = null!;
    public Showtime Showtime { get; set; } = null!;
}