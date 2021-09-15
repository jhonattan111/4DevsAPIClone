using _4DevsAPIClone.Models;
using _4DevsAPIClone.Models.ControllerModels;
using _4DevsAPIClone.Services.Interfaces;
using _4DevsAPIClone.Enums;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net;

namespace _4DevsAPIClone.Services;
public class AdressServices : IAdressServices
{
    public Adress GenerateAdress(AdressSettings adressSettings)
    {
        var random = new Random();

        Adress adress = new Adress();

        string zipCode = string.Empty;

        switch (adressSettings.State)
        {
            case EState.AC:
                zipCode = "6"; break;
            case EState.AL:
                zipCode = "5"; break;
            case EState.AP:
                zipCode = "6"; break;
            case EState.AM:
                zipCode = "6"; break;
            case EState.BA:
                zipCode = "4"; break;
            case EState.CE:
                zipCode = "6"; break;
            case EState.DF:
                zipCode = "7"; break;
            case EState.ES:
                zipCode = "2"; break;
            case EState.GO:
                zipCode = "7"; break;
            case EState.MA:
                zipCode = "6"; break;
            case EState.MT:
                zipCode = "7"; break;
            case EState.MS:
                zipCode = "7"; break;
            case EState.MG:
                zipCode = "3"; break;
            case EState.PA:
                zipCode = "6"; break;
            case EState.PB:
                zipCode = "5"; break;
            case EState.PR:
                zipCode = "8"; break;
            case EState.PE:
                zipCode = "5"; break;
            case EState.PI:
                zipCode = "6"; break;
            case EState.RJ:
                zipCode = "2"; break;
            case EState.RN:
                zipCode = "5"; break;
            case EState.RS:
                zipCode = "9"; break;
            case EState.RO:
                zipCode = "7"; break;
            case EState.RR:
                zipCode = "6"; break;
            case EState.SC:
                zipCode = "8"; break;
            case EState.SP:
                zipCode = "0"; break;
            case EState.SI:
                zipCode = "1"; break;
            case EState.SE:
                zipCode = "4"; break;
            case EState.TO:
                zipCode = "7"; break;
            default:
                zipCode = $"{random.Next(0, 9)}"; break;
        }

        zipCode += $"{random.Next(0, 9999):0000}{random.Next(0, 999):000}";

        ConsultZipCode(zipCode);

        return new Adress();
    }

    public Adress ConsultZipCode(string zipCode)
    {
        string url = $"https://viacep.com.br/ws/{zipCode}/json/";
        var a = new HttpClient();
        var cepAPI = a.GetAsync(url);

        return new Adress();
    }
}
