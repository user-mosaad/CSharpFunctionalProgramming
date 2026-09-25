namespace CSharpFunctionalProgramming;

class Program
{
    static void Main()
    {
        // 1. Explicit declaration of types
        (string city, int population, double area) = QueryCityData("New York City");
        // 2. Using 'var'
        var (cityy, populationy, areay) = QueryCityData("New York City");

        // Person class
        var p = new Person("John", "Quirky", "Adams", "Boston", "MA");
        var (fName, lName, cityyy, state) = p;
        Console.WriteLine($"Hello {fName} {lName} of {city}, {state}!");
    }

    private static (string, int, double) QueryCityData(string name)
    {
        if (name == "New York City")
        {
            return (name, 8_175_133, 468.48);
        }
        return ("", 0, 0);
    }
}
