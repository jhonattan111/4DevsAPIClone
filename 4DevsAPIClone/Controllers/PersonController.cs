using _4DevsAPIClone.Models.ControllerModels;
using _4DevsAPIClone.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _4DevsAPIClone.Controllers;
[ApiController]
[Route("v1/person")]
public class PersonController : ControllerBase
{
    [HttpGet]
    [Route("generatecnpj")]
    public ActionResult<List<string>> GenerateCNPJ([FromBody] CPFSettings cpfSettings, [FromServices] ILegalPersonServices legalServices) => 
        legalServices.GenerateCNPJ(cpfSettings).ToList();

    [HttpGet]
    [Route("validatecnpj")]
    public ActionResult<IEnumerable<bool>> ValidateCNPJ([FromBody] IEnumerable<string> cnpjs, [FromServices] ILegalPersonServices legalServices) => 
        legalServices.ValidateCNPJ(cnpjs).ToList();

    [HttpGet]
    [Route("generatecpf")]
    public ActionResult<List<string>> GenerateCPF([FromBody] CNPJSettings cnpjSettings, [FromServices] IPhysicalPersonServices physicalServices) => 
        physicalServices.GenerateCPF(cnpjSettings).ToList();

    [HttpGet]
    [Route("validatecpf")]
    public ActionResult<IEnumerable<bool>> ValidateCPF([FromBody] IEnumerable<string> cpfs, [FromServices] IPhysicalPersonServices physicalServices) =>
        physicalServices.ValidateCPF(cpfs).ToList();
}
