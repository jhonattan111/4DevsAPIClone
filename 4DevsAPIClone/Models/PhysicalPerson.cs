
namespace _4DevsAPIClone.Models;
public class PhysicalPerson : Person
{
    public PhysicalPerson(string name, string cpf) : base(name)
    {
        Name = name;
        CPF = cpf;
    }
    public string CPF { get; set; }
}
