using Highscores.Areas.API.Models;
using Highscores.Data;
using Highscores.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Highscores.Areas.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly HighscoresContext context;

        public PlayersController(HighscoresContext context)
        {
            this.context = context;
        }

        
        [HttpGet]
        public IEnumerable<PlayerDto> GetAll()
        {
            var players = context.Players.ToList();
            var dto = players.Select(ToPlayersDto);
            return dto;
        }

        public PlayerDto ToPlayersDto(Player player)
            => new PlayerDto
            {
                Id = player.Id,
                Name = player.Name,
                UrlSlug = player.UrlSlug,
            };

    }
}
