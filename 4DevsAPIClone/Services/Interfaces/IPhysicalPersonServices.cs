using _4DevsAPIClone.Models.ControllerModels;
using System.Collections.Generic;

namespace _4DevsAPIClone.Services.Interfaces;
public interface IPhysicalPersonServices
{
    IEnumerable<string> GenerateCPF(CPFSettings cpfSettings);
    IEnumerable<bool> ValidateCPF(IEnumerable<string> cpfs);
}
