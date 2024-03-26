namespace TheaterSystem.Domain.Entities;

public class Director
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public DateTime BirthDay { get; set; } = new DateTime(1970, 1, 1);
    public int CountryId { get; set; } = 0;
    public Country Country { get; set; } = null!;
}