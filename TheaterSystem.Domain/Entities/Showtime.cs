namespace TheaterSystem.Domain.Entities;

public class Showtime
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime ShowtimeDate { get; set; } = new DateTime(1970, 1, 1);
    public int AuditoriumId { get; set; } = 0;
    public Auditorium Auditorium { get; set; } = null!;
    public int Movie { get; set; } = 0;
}