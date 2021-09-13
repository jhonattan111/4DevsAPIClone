
using _4DevsAPIClone.Services;

namespace _4DevsAPIClone.Models;
public class LegalPerson : Person
{
    public LegalPerson(string name, string cnpj) : base(name)
    {
        Name = name;
        CNPJ = cnpj;
    }
    public string CNPJ { get; set; }
}
