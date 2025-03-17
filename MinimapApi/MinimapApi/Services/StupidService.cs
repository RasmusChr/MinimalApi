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

    public string GetStupid5()
    {
        var en = 1;
        var to = 2;
        var tre = 3;
        var fire = 4;
        var fem = 5;
        var seks = 6;
        var syv = 7;
        var otte = 8;
        var sum = en + to + tre + fire + fem + seks + syv + otte;
        return "Summen af tallene er " + sum;
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