using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

namespace BuberBreakfast.Services;

public class BreakfastService : IBreakfastService
{
private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

    public ErrorOr<Created> CreateBreakfast(Breakfast request)
    {
        _breakfasts.TryAdd(request.Id, request);
        
            return Result.Created;
        
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);

        return Result.Deleted;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (_breakfasts.TryGetValue(id, out var breakfast))
        {
            return breakfast;
        }

        return Errors.Breakfast.NotFound;
    }

    public IEnumerable<Breakfast> GetBreakfasts()
    {
        return _breakfasts.Values;
    }

    public ErrorOr<Updated> UpdateBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;

        return Result.Updated; 
    }
}