using Highscores.Data;
using Highscores.Data.Entities;
using Highscores.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Highscores.Controllers
{
    public class HomeController : Controller
    {
        // CONTROLLERE SE OCUPA CU TRIMITEREA DE DATE ( LUATE DIN BAZA DE DATE ) CATRE VIEW
        // SUNT O LEGATURA, SAU REPREZINTA LEGATURA DINTRE BAZA DE DATE SI VIEW

        private readonly HighscoresContext context;

        //se initializeaza obiectul context cu ce vine ca parametru
        public HomeController(HighscoresContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {


            List<Highscore> maxHighscores = new List<Highscore>();

            List<Game> games = context.Games.ToList();
            List<Highscore> highscores = context.Highscores.ToList();

            foreach (Game game in games)
            {
                Highscore maxHighscore = highscores.First();
                foreach(Highscore highscore in highscores)
                {
                    if(highscore.GameId == game.Id)
                    {
                        if(maxHighscore.Score < highscore.Score)
                        {
                            maxHighscore = highscore;
                        }
                    }
                }
                maxHighscore.Game = context.Games.Where(x => x.Id == maxHighscore.GameId).FirstOrDefault();
                maxHighscore.Player = context.Players.Where(x => x.Id == maxHighscore.PlayerId).FirstOrDefault();
                maxHighscores.Add(maxHighscore);
            }

            return View(maxHighscores);
        }
    }
}
