using BuberBreakfast.Contracts;
using BuberBreakfast.Models;

namespace BuberBreakfast.Extensions;

public static class BreakfastExtensions
{
    public static Breakfast ToBreakfast(this CreateBreakfastRequest request)
    {
        return new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet);
    }

    public static CreateBreakfastResponse ToCreateBreakfastResponse(this Breakfast breakfast)
    {
        return new CreateBreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.Savory,
            breakfast.Sweet);
    }

    public static GetBreakfastResponse ToGetBreakfastResponse(this Breakfast breakfast)
    {
        return new GetBreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.Savory,
            breakfast.Sweet);
    }

    
    public static IEnumerable<GetBreakfastResponse> ToGetBreakfastResponse(this IEnumerable<Breakfast> breakfasts)
    {
        foreach (var breakfast in breakfasts)
        {
            yield return breakfast.ToGetBreakfastResponse();
        }
    }


    public static Breakfast ToUpdateBreakfastResponse(this UpdateBreakfastRequest breakfast, Guid id)
    {
        return new Breakfast(
            id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            DateTime.UtcNow,
            breakfast.Savory,
            breakfast.Sweet);
    }
}