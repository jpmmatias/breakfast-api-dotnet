namespace BurberBreakfast.Contracts.BurberBreakfast;

public record UppsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);