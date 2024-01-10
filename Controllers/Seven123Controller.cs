
using MC_Five_to_Seven.Services.Seven123;
using Microsoft.AspNetCore.Mvc;

namespace MC_Five_to_Seven.Controllers;

[ApiController]
[Route("[controller]")]
public class Seven123Controller : ControllerBase
{
    private readonly ISeven123Service _seven123Service;

    public Seven123Controller(ISeven123Service seven123Service)
    {
        _seven123Service = seven123Service;
    }
    [HttpGet]
    [Route("ReversedNum/{revNum}")]
    public string reverse123(string revMe)
    {
        return _seven123Service.reverse123(revMe);
    }

}
