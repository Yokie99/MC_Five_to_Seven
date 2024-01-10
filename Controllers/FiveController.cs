
using MC_Five_to_Seven.Services.Five;
using Microsoft.AspNetCore.Mvc;

namespace MC_Five_to_Seven.Controllers;
[ApiController]
[Route("[controller]")]
public class FiveController : ControllerBase
{

    private readonly IFiveService _fiveService;
    public FiveController(IFiveService fiveService)
    {
        _fiveService = fiveService;
    }

    [HttpGet]
    [Route("hold")]

    public string Mablib(string name)
    {
        return _fiveService.Mablib(name);
    }

}
