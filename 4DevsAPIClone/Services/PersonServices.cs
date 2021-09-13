using _4DevsAPIClone.Models;
using _4DevsAPIClone.Models.ControllerModels;
using _4DevsAPIClone.Services.Interfaces;

namespace _4DevsAPIClone.Services;
public class PersonServices : IPersonServices
{
    public IEnumerable<Adress> GenerateAdress(AdressSettings adressSettings)
    {
        List<Adress> adresses = new List<Adress>();

        for(int i = 0; i < adressSettings.Quantity; i++)
        {
            var random = new Random();
        }

        throw new NotImplementedException();

        //public IEnumerable<string> GenerateCNPJ(CPFSettings cpfSettings)
        //{
        //    List<string> cnpjs = new List<string>();
        //
        //    for (int i = 0; i < cpfSettings.Quantity; i++)
        //    {
        //
        //        var random = new Random();
        //        string cnpj = string.Empty;
        //        // 00.000.000/0000-00
        //        for (int j = 0; j <= 11; j++)
        //            cnpj = $"{cnpj}{(random.Next(0, 9).ToString())}";
        //
        //        string digits = GenerateDigits(cnpj);
        //
        //        cnpj += digits;
        //
        //        if (cpfSettings.Formated)
        //            cnpj = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";
        //
        //        cnpjs.Add(cnpj);
        //    }
        //
        //    return cnpjs;
        //}
    }
}
