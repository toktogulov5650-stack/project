using Project.Application.Interfaces.Services;

namespace Project.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvaider
{
    public DateTime UtcNow => DateTime.UtcNow;
}