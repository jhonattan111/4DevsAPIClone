using _4DevsAPIClone.Models.ControllerModels;

namespace _4DevsAPIClone.Services;
public interface IPhysicalPersonServices
{
    IEnumerable<string> GenerateCPF(CNPJSettings cnpjSettings);
    bool ValidateCPF(string cpf);
}
