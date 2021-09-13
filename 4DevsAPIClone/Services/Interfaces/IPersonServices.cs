using _4DevsAPIClone.Models;
using _4DevsAPIClone.Models.ControllerModels;

namespace _4DevsAPIClone.Services.Interfaces;
public interface IPersonServices
{
    IEnumerable<Adress> GenerateAdress(AdressSettings adressSettings);
}
