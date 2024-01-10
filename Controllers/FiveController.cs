
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
    [Route("MadLib/{superheroName}/{city}/{animal}/{scaryThing}/{dessert}/{anime}")]

    public string Mablib(string superheroName, string city, string animal, string scaryThing, string dessert, string anime)
    {
        return _fiveService.Mablib(superheroName, city, animal, scaryThing, dessert, anime);
    }

}
