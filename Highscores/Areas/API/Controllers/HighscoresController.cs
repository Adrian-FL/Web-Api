using Highscores.Areas.API.Models;
using Highscores.Data;
using Highscores.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Highscores.Areas.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HighscoresController : ControllerBase
    {
        private readonly HighscoresContext context;

        public HighscoresController(HighscoresContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public IEnumerable<Highscore> GetAll()
        {
            var highscores = context.Highscores.ToList();
            return highscores;
        }

        // api/highscores/1/2
        [HttpGet("{gameId}/{playerId}")] //[HttpGet("{id:int}")] 
        public ActionResult<HighscoreDto> GetById(int gameId, int playerId)      
        {
            var highscore = context.Highscores.FirstOrDefault(x => x.GameId == gameId && x.PlayerId == playerId);
            if (highscore == null)
            {
                //404 Not Found 
                return NotFound();
            }

            var dto = toHighscoreDto(highscore);
            // 200 ok 
            return dto;
        }
        [HttpPost]
        public async Task<ActionResult<HighscoreDto>> CreateHighscore(CreateHighscoreDto createHighscore)
        {
            var newHighscore = new Highscore(
                createHighscore.GameId,
                createHighscore.PlayerId,
                createHighscore.Score,
                createHighscore.Date,
                createHighscore.Game,
                createHighscore.Player
                );

            await context.Highscores.AddAsync(newHighscore);

            await context.SaveChangesAsync();

            var highscoreDto = toHighscoreDto(newHighscore);

            return CreatedAtAction(nameof(GetById), new
            {
                gameId = newHighscore.GameId,
                playerId = newHighscore.PlayerId
            }, highscoreDto);
        }

        public HighscoreDto toHighscoreDto(Highscore Highscore)
            => new HighscoreDto
            {
                GameId = Highscore.GameId,
                PlayerId = Highscore.PlayerId,
                Date = Highscore.Date,
                Score = Highscore.Score,
                Game = Highscore.Game,
                Player = Highscore.Player,
            };       
    }
}
