
namespace _4DevsAPIClone.Models;
public abstract class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
