namespace DodgeAndCox.Models;

public record Album(
    int Id,
    string Title,
    string Artist,
    int YearReleased,
    string Genre,
    string Label,
    int TrackCount,
    int DurationMinutes
);
