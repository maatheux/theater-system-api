namespace TheaterSystem.Domain.Entities;

public class Movie
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public DateTime Release { get; set; } = new DateTime(1970, 1, 1);
    public int Rating { get; set; } = 0;
    public TimeSpan Runtime { get; set; } = new TimeSpan(0, 0, 0);
    public string ParentalGuide { get; set; } = null!;
    public int CountryId { get; set; } = 0;
    public Country Country { get; set; } = null!;
    public List<Actor> Actors { get; set; } = new();
    public List<Director> Directors { get; set; } = new();
    public List<Genre> Genres { get; set; } = new();
}