
namespace _4DevsAPIClone.Models;
public class Adress
{
    //{
    //  "cep": "28630-300",
    //  "logradouro": "Rua Érico Hees",
    //  "complemento": "",
    //  "bairro": "Córrego D'Antas",
    //  "localidade": "Nova Friburgo",
    //  "uf": "RJ",
    //  "ibge": "3303401",
    //  "gia": "",
    //  "ddd": "22",
    //  "siafi": "5867"
    //}

    public Adress(string cep, string logradouro, string bairro, string localidade, string uf, string ibge, string gia, string ddd, string siafi)
    {
        ZipCode = cep;
        Street = logradouro;
        State = uf;
        IBGECode = ibge;
        City = localidade;
        District = bairro;
    }

    public string ZipCode { get; set; }
    public string Street { get; set; }
    public string State { get; set; }
    public string IBGECode { get; set; }
    public string City { get; set; }
    public string District { get; set; }
}
