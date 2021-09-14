using _4DevsAPIClone.Models;
using _4DevsAPIClone.Models.ControllerModels;
using _4DevsAPIClone.Services.Interfaces;
using _4DevsAPIClone.Enums;

namespace _4DevsAPIClone.Services;
public class AdressServices : IAdressServices
{
    public Adress GenerateAdress(AdressSettings adressSettings)
    {
        string ZipCod = string.Empty;

        switch (adressSettings.State)
        {
            case EState.RJ:
                ZipCod = "1";

            default:
                ZipCod = "2";
            //AL,
            //AP,
            //AM,
            //BA,
            //CE,
            //DF,
            //ES,
            //GO,
            //MA,
            //MT,
            //MS,
            //MG,
            //PA,
            //PB,
            //PR,
            //PE,
            //PI,
            //RJ,
            //RN,
            //RS,
            //RO,
            //RR,
            //SC,
            //SP,
            //SE,
            //TO
        }
    }
}
