using PersonDataLibrary.Models;

// var person = new Person();
Person p = new("Jonas", "Hellum", 26, "Mann");
// {
//     FirstName = "Jonas",
//     Age = 26,
//     Gender = "Mann",
//     LastName = "Hellum"
// };


Person p2 = new()
{
    FirstName = "Jonas",
    Age = 26,
    Gender = "Mann",
    LastName = "Hellum"
};



Console.WriteLine($"FirstName: {p.FirstName}, LastName: {p.LastName}");
Console.WriteLine(p2);


//p.FirstName = "Viggo";

//Person p2 = new();
//p2.FirstName = "Jonas 2";

