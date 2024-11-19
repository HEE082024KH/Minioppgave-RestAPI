using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/videogames")]

public class VideoGamesController : ControllerBase
{
  private static List<VideoGame> VideoGames = new List<VideoGame>
  {
    new VideoGame {Id = 1, Title = "Crash Bandicoot", Developer = "Naughty Dog", Year = 1996},
    new VideoGame {Id = 2, Title = "Rimworld", Developer = "Ludeon Studios", Year = 2013},
    new VideoGame {Id = 3, Title = "World of Warcraft", Developer = "Blizzard", Year = 2004},
    new VideoGame {Id = 4, Title = "XCOM: Enemy Unknown", Developer = "Firaxis Games", Year = 2012},
    new VideoGame {Id = 5, Title = "Need for Speed: Underground", Developer = "EA", Year = 2003}
  };
}