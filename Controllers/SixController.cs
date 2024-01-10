
using MC_Five_to_Seven.Services.Six;
using Microsoft.AspNetCore.Mvc;

namespace MC_Five_to_Seven.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class SixController : ControllerBase
    {
    private readonly ISixService _sixService;

    public SixController(ISixService sixService)
        {
        _sixService = sixService;
    }

    [HttpGet]
    [Route("OddOrEven/{num}")]
        public string OddOrEven(string num)
        {
            return _sixService.OddOrEven(num);
        }
    }
