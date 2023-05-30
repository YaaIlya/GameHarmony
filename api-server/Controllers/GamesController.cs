using api_server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly ILogger<GamesController> _logger;
    private readonly GamesMatchContext _dbContext;

    public GamesController(ILogger<GamesController> logger)
    {
        _logger = logger;
        _dbContext = new GamesMatchContext();
    }

    [HttpGet("{id:int}")]
    public Game? GetGame(int id)
    {
        return _dbContext.Games.Find(id);
    }

    [HttpGet("search")]
    public async Task<List<Game>> SearchGames([FromQuery(Name = "s")] string search)
    {
        var records = await _dbContext.Games
            .Where(x => EF.Functions.Like(x.Name, "%" + search + "%"))
            //.Include(x => x.Developers)
            .Take(10)
            .ToListAsync();

        return records;
    }

    [HttpGet("match")]
    public List<Game> GetMatch([FromQuery(Name = "id1")] int id1, [FromQuery(Name = "id2")] int id2)
    {
        Game? game1 = _dbContext.Games.Find(id1);
        Game? game2 = _dbContext.Games.Find(id2);
        List<Game> result = new List<Game>();

        // Тут логика наполения списка игр по пересечению
        // В качестве загрулшки наполнил заданными играми
        if (game1 != null && game2 != null) {
            result.Add(game1);
            result.Add(game2);
        }

        return result;
    }
}
