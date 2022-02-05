using Highscores.Data;
using Highscores.Data.Entities;
using Highscores.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Highscores.Controllers
{
    public class GameController : Controller
    {
        private readonly HighscoresContext context;

        public GameController(HighscoresContext context)
        {
            this.context = context;
        }

        [Route("/games/{gameUrlSlug}")]
        public IActionResult GameDetail(string gameUrlSlug)
        {
            Debug.WriteLine(gameUrlSlug);

            Game game = context.Games.FirstOrDefault(game => game.UrlSlug == gameUrlSlug);

            
            game.Highscores = context.Highscores.Include(h => h.Player).Where(highscore => highscore.GameId == game.Id).OrderByDescending(highscore => highscore.Score).ToList();

            Debug.WriteLine(game.Highscores.Count);

            return View(game);
        }
    }
}
