using System.Collections;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/videogames")]

public class VideoGamesController : ControllerBase
{
  private static List<VideoGames> VideoGamesList = new List<VideoGames>
  {
    new VideoGames {Id = 1, Title = "Crash Bandicoot", Developer = "Naughty Dog", Year = 1996},
    new VideoGames {Id = 2, Title = "Rimworld", Developer = "Ludeon Studios", Year = 2013},
    new VideoGames {Id = 3, Title = "World of Warcraft", Developer = "Blizzard", Year = 2004},
    new VideoGames {Id = 4, Title = "XCOM: Enemy Unknown", Developer = "Firaxis Games", Year = 2012},
    new VideoGames {Id = 5, Title = "Need for Speed: Underground", Developer = "EA", Year = 2003}
  };

  [HttpGet]
  public IEnumerable<VideoGames> Get()
  {
    return VideoGamesList;
  }

}