namespace BuberBreakfast.Models;

public class Breakfast
{
    public Breakfast(
        Guid id,
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime lastModifiedDateTime,
        List<string> savory,
        List<string> sweet)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savory = savory;
        Sweet = sweet;
    }

    public Guid Id { get; init; }
    public string Name { get;  init;}
    public string Description { get; init;}
    public DateTime StartDateTime { get;  init;}
    public DateTime EndDateTime { get; init; }
    public DateTime LastModifiedDateTime { get; init; }
    public List<string> Savory { get; init; }
    public List<string> Sweet { get;  init;}
}