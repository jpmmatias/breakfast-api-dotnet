using BurberBreakfast.Models;

namespace BurberBreakfast.Services.Breakfasts;

public class BreakfastsServices : IBreakfastService{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
     _breakfasts.Add(breakfast.Id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {

     Breakfast breakfast = _breakfasts.First().Value;

     Console.WriteLine(breakfast);
     return breakfast;
    }
    public Dictionary<Guid, Breakfast>  ReturnAllBreakfasts()
    {
      Dictionary<Guid, Breakfast> breakfasts = _breakfasts;
       return breakfasts;
    }

    public void UpdateBreakfast(Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;
    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);
    }


}