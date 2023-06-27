namespace BurberBreakfast.Services.Breakfasts;
using BurberBreakfast.Models;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    Dictionary<Guid, Breakfast>   ReturnAllBreakfasts();
    Breakfast GetBreakfast(Guid id);
    void UpdateBreakfast(Breakfast breakfast);

    void DeleteBreakfast(Guid id);


}