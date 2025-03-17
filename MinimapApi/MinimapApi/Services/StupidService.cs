namespace MinimapApi.Services;

public class StupidService : IStupidService
{
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

    public string GetStupid2()
    {
        return "Hello";
    }
    
    public string getStupid4()
    {
        var firstName = "carl";
        var LastName = "jakobsen";
        var fullName = firstName + LastName;
        return fullName;
    }

    public string GetStupid3()
    {
        var firstName = "carl";
        var LastName = "jakobsen";
        var fullName = firstName + LastName;
        var yearBorn = 1990;
        var currentYear = DateTime.Now.Year;
        var age = currentYear - yearBorn;

        return fullName + " is " + age + " years old3";
    }
}