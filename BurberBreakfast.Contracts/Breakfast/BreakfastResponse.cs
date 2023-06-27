
namespace BurberBreakfast.Contracts.BurberBreakfast;

public record BreakfastResponse
(
   Guid Id,
   string Name,
   string Description,
   DateTime StartDateTime,
   DateTime EndDateTime,
   DateTime LastModiDateTime,
   List<string> Savory,
   List<string> Sweet
);