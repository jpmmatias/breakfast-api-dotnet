namespace BurberBreakfast.Models;

public class Breakfast
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public DateTime LastModiDateTime { get; set; }
    public List<string> Savory { get; set; } = new List<string>();
    public List<string> Sweet { get; set; } = new List<string>();

    public Breakfast(
        Guid id,
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime lastModiDateTime,
        List<string> savory,
        List<string> sweet
    ){
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModiDateTime = lastModiDateTime;
        Savory = savory;
        Sweet = sweet;
    }
}