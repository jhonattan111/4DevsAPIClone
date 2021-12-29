using _4DevsAPIClone.Models.ControllerModels;
using System.Collections.Generic;

namespace _4DevsAPIClone.Services.Interfaces;
public interface ILegalPersonServices
{
    IEnumerable<string> GenerateCNPJ(CPFSettings cpfSettings);
    IEnumerable<bool> ValidateCNPJ(IEnumerable<string> cnpjs);
}
