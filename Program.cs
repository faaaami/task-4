using System;
using System.Collections.Generic;
using System.Linq;

// Person class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create list of Person objects
        List<Person> people = new List<Person>()
        {
            new Person { Name = "Ali", Age = 30, City = "Dubai" },
            new Person { Name = "Sara", Age = 22, City = "Dubai" },
            new Person { Name = "John", Age = 28, City = "London" },
            new Person { Name = "Aisha", Age = 35, City = "Dubai" },
            new Person { Name = "Rahul", Age = 26, City = "Dubai" }
        };

        // Step 2: LINQ - Filter + Project
        var filteredPeople = people
            .Where(p => p.Age > 25 && p.City == "Dubai")
            .Select(p => new { p.Name, p.Age });

        // Step 3: Display result
        Console.WriteLine("Filtered People:\n");

        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        Console.ReadLine();
    }
}