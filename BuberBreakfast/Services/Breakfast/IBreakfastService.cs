using BuberBreakfast.Contracts;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast request);
    ErrorOr<Deleted> DeleteBreakfast(Guid id);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    IEnumerable<Breakfast> GetBreakfasts();
    ErrorOr<Updated> UpdateBreakfast(Breakfast breakfast);
}