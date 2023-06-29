
namespace BuberBreakfast.Contracts;

public record GetBreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime startDateTime,
    DateTime endDateTime,
    List<string> Savory,
    List<string> Sweet);
