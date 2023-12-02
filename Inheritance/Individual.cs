using Abstraction;

public class Individual : Client
{
    public string Firstname;
    public string Lastname;

    public Individual(int id) : base(id)
    {
        Console.WriteLine("Ind");
    }
    // public Individual(int id) : base(id)
    // {
    // }
}