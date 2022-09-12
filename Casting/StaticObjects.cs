namespace Casting;

public class StaticObjects
{
    public static object Nick = new Person
    {
        Id = Guid.NewGuid(),
        Fullname = "Nick Chapsas"
    };

    public static List<object> People = Enumerable
        .Range(0, 1000)
        .Select(x => (object)new Person
        {
            Id = Guid.NewGuid(),
            Fullname = Guid.NewGuid().ToString()
        }).ToList();
}