
namespace MC_Five_to_Seven.Services.Five;
    public class FiveService : IFiveService
    {
        public string Mablib(string superheroName, string city, string animal, string scaryThing, string dessert, string anime)
        {
            return $"This looks like a job for {superheroName} and {superheroName}'s sidekick the magic {animal}. {city} is in danger from the invading {scaryThing}. Good thing {scaryThing} is no match for {superheroName}. After a of good day of crime stopping {superheroName}, celebrates his wins with some {dessert} and watching {anime}.";
        }
    }
