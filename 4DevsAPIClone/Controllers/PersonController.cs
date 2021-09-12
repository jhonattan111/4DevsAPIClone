using _4DevsAPIClone.Models.ControllerModels;
using _4DevsAPIClone.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _4DevsAPIClone.Controllers;
[ApiController]
[Route("v1/person")]
public class PersonController : ControllerBase
{
    [HttpGet]
    [Route("generatecnpj")]
    public ActionResult<List<string>> GenerateCNPJ([FromBody] CPFSettings cpfSettings, [FromServices] ILegalPersonServices legalServices)
    {
        return legalServices.GenerateCNPJ(cpfSettings).ToList();

        //int.Parse(Convert.ToString(DadosRetornoJson["open_id"])
    }

    [HttpGet]
    [Route("validatecnpj")]
    public ActionResult<List<bool>> ValidateCNPJ([FromBody] IEnumerable<string> cnpjs, [FromServices] ILegalPersonServices legalServices)
    {
        return legalServices.ValidateCNPJ(cnpjs).ToList();
    }

    [HttpGet]
    [Route("generatecpf")]
    public ActionResult<List<string>> GenerateCPF([FromBody] CNPJSettings cnpjSettings, [FromServices] IPhysicalPersonServices physicalServices)
    {
        return physicalServices.GenerateCPF(cnpjSettings).ToList();
    }

    [HttpGet]
    [Route("validatecpf")]
    public ActionResult<bool> ValidateCPF([FromBody] string cpf, [FromServices] IPhysicalPersonServices physicalServices)
    {
        return physicalServices.ValidateCPF(cpf);
    }
}
