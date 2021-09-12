using _4DevsAPIClone.Models.ControllerModels;
namespace _4DevsAPIClone.Services;
public interface ILegalPersonServices
{
    IEnumerable<string> GenerateCNPJ(CPFSettings cpfSettings);
    IEnumerable<bool> ValidateCNPJ(IEnumerable<string> cnpjs);
}
