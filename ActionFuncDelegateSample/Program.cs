using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        ServiceCollection services = new();
        
        var provider = services.BuildServiceProvider();


        //Func returns value, Action Doesn't

        Action<string> actionDelegate = new(DisplayText);
        actionDelegate("Mr Dude");

        Func<double, string> funcDelegate = new(GetTax);
        Console.WriteLine(funcDelegate(10000));


        Predicate<Person> findFilter = c => c.Id == 1;
        var foundCustomers = custList.Find(findFilter);

        Predicate<Person> whereFilter = c => c.Country == "India";
        var filteredCustomers = custList.Find(whereFilter);

        Console.ReadLine();
    }

    private static void DisplayText(string name)
    {
        Console.WriteLine($"Welcome {name}!");
    }

    private static string GetTax(double netSalary)
    {
        return "Your Tex amount is " + (netSalary * .3);
    }

    static List<Person> custList = new List<Person>()
    {
        new Person { Id = 1, FirstName = "Sumi", LastName = "Murugesan", City = "Chidambaram", Country = "India" },
        new Person { Id = 2, FirstName = "Shoba", LastName = "Murugesan", City = "Chennai", Country = "India" } ,
        new Person { Id = 3, FirstName = "Revathy", LastName = "Murugesan", City = "Philadelphia" , Country = "USA"}
    };
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}