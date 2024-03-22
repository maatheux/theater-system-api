using TheaterSystem.Application.Common.Interfaces.Services;

namespace TheaterSystem.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}