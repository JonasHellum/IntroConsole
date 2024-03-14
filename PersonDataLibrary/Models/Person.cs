namespace PersonDataLibrary.Models;

public class Person
{
    public Person()
    {
        
    }
    
    public Person(string firstName, string lastName, int age, string gender)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
    }
    
    
    // Fornavn,Etternavn,Alder,Kjønn
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public int Age { get; init; }
    public string Gender { get; init; } = string.Empty;

    public override string ToString()
    {
        return $"{FirstName}, {LastName}, {Age}, {Gender}";
    }
}