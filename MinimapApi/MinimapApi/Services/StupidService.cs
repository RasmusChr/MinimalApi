namespace MinimapApi.Services;

public class StupidService : IStupidService
{
    private static readonly string[] Summaries = {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public string GetStupid()
    {
        var firstName = "carl";
        var LastName = "jakobsen";
        var fullName = firstName + LastName;
        var yearBorn = 1990;
        var currentYear = DateTime.Now.Year;
        var age = currentYear - yearBorn;
        
        return fullName + " is " + age + " years old";
    }
}