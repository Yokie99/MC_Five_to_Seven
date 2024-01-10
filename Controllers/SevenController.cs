
using MC_Five_to_Seven.Services.Seven;
using Microsoft.AspNetCore.Mvc;

namespace MC_Five_to_Seven.Controllers;

[ApiController]
[Route("[controller]")]
public class SevenController : ControllerBase
{
    private readonly ISevenService _sevenService;

    public SevenController(ISevenService sevenService)
    {
        _sevenService = sevenService;
    }
    [HttpGet]
    [Route("Reversed/{revMe}")]
    public string reverseABC(string revMe)
    {
        return _sevenService.reverseABC(revMe);
    }

}
