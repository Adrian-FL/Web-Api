using Highscores.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Highscores.Data.Entities;
using Highscores.Models.ViewModels;
using System;

namespace Highscores.Controllers
{
    public class HighscoresController : Controller
    {
        private readonly HighscoresContext context;

        //se initializeaza obiectul context cu ce vine ca parametru
        public HighscoresController(HighscoresContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("/highscores/new")]
        public IActionResult Create()
        {
            CreateHighscoreViewModel model = new CreateHighscoreViewModel();
            model.Games = context.Games.ToList();
            model.Date = DateTime.Now;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/highscores/new")]
        public IActionResult Create([Bind("Game, Player, Date, Score, Games")] CreateHighscoreViewModel model)
        {
            if (ModelState.IsValid)
            {
                Player player = context.Players.FirstOrDefault(player => player.Name == model.Player);

                if (player == null)
                {
                    context.Players.Add(new Player(model.Player));
                    context.SaveChanges();
                    player = context.Players.FirstOrDefault(player => player.Name == model.Player);
                }

                Game game = context.Games.FirstOrDefault(game => game.Name == model.Game);

                Highscore highscore = context.Highscores.FirstOrDefault(highscore => highscore.PlayerId == player.Id && highscore.GameId == game.Id);

                if (highscore != null)
                {
                    if (highscore.Score < model.Score)
                    {
                        highscore.Score = model.Score;
                        highscore.Date = model.Date;
                    }
                }
                else
                {
                    highscore = new Highscore(
                        game.Id,
                        player.Id,
                        model.Score,
                        model.Date
                    );
                    context.Highscores.Add(highscore);
                }

                context.SaveChanges();

                return Redirect("/");
            }

            model.Games = context.Games.ToList();
            return View(model);
        }
    }
}
