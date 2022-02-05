using Highscores.Areas.API.Models;
using Highscores.Data;
using Highscores.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Highscores.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly HighscoresContext context;
        public GamesController(HighscoresContext context)
        {
            this.context = context;
        }



        // GET: /api/games
        [HttpGet]
        public IEnumerable<GameDto> GetAll()
        {
            var games = context.Games.ToList();
            var dto = games.Select(ToGameDto);

            return dto;
        }
        
        // POST: /api/games
        [HttpPost]       
        public async Task<ActionResult<GameDto>> CreateGame(CreateGameDto createGame)
        {
            // TODO generate id for game
            var newGame = new Game(
                createGame.Name,
                createGame.Description,
                createGame.ReleaseYear,
                createGame.ImageUrl
                );


            await context.Games.AddAsync(newGame);
            await context.SaveChangesAsync();

            var gameDto = ToGameDto(newGame);

            return CreatedAtAction(nameof(GetById), new { id = newGame.Id }, gameDto);
        }

        public GameDto ToGameDto(Game game)
            => new GameDto
            {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description,
                ReleaseYear = game.ReleaseYear,
                Genre = game.Genre,
                IamgeUrl = game.ImageUrl.AbsoluteUri,
            };

        //GET /api/game/{id}, ex: "/api/game/1"
        [HttpGet("{id}")] //[HttpGet("{id:int}")] 
        public ActionResult<GameDto> GetById(int id)
        //public IActionResult GetById(int id)
        {
            var game = context.Games.FirstOrDefault(x => x.Id == id);
            if (game == null)
            {
                //404 Not Found 
                return NotFound();
            }

            var dto = ToGameDto(game);
            // 200 ok 
            return dto;
        }

        [HttpDelete("{id}")] //[HttpDelete("{id:int}")] 
        public async Task<ActionResult<string>> DeleteById(int id)
        //public IActionResult GetById(int id)
        {
            var game = context.Games.FirstOrDefault(x => x.Id == id);

            if (game == null)
            {
                //404 Not Found 
                return NotFound();
            }

            context.Games.Remove(game);
            await context.SaveChangesAsync();

            return "DELETE success";
        }
    }
}
