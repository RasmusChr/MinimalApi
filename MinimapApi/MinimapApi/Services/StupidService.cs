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


    public string GetStupid6()
    {
        var firstName = "carl";
        var LastName = "jakobsen";
        var fullName = firstName + LastName;
        var yearBorn = 1990;
        var currentYear = DateTime.Now.Year;
        var age = currentYear - yearBorn;
            
        return fullName + " is " + age + " years old6";
    }
    
    public string GetStupid7()
    {
        var firstName = "carl";
        var LastName = "jakobsen";
        var fullName = firstName + LastName;
        var yearBorn = 1990;
        var currentYear = DateTime.Now.Year;
        var age = currentYear - yearBorn;
            
        return fullName + " is " + age + " years old6";
    }
    
    
    public string GetStupid8()
    {
        var firstName = "carl";
        var LastName = "jakobsen";
        var fullName = firstName + LastName;
        var yearBorn = 1990;
        var currentYear = DateTime.Now.Year;
        var age = currentYear - yearBorn;
            
        return fullName + " is " + age + " years old6";
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