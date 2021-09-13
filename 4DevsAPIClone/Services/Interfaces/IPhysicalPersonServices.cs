using _4DevsAPIClone.Models.ControllerModels;

namespace _4DevsAPIClone.Services.Interfaces;
public interface IPhysicalPersonServices
{
    IEnumerable<string> GenerateCPF(CPFSettings cpfSettings);
    IEnumerable<bool> ValidateCPF(IEnumerable<string> cpfs);
}
