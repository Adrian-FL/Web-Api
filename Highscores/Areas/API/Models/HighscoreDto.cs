using Highscores.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscores.Areas.API.Models
{

    public class HighscoreDto
    {
        public HighscoreDto() { }
        public HighscoreDto(int gameId, int playerId, int score, DateTime date)
        {
            GameId = gameId;
            PlayerId = playerId;
            Score = score;
            Date = date;
        }
        public HighscoreDto(int gameId, int playerId, int score, DateTime date, Game game, Player player)
        {
            GameId = gameId;
            PlayerId = playerId;
            Score = score;
            Date = date;
            Game = game;
            Player = player;

        }
        public int GameId { get; set; }
        
        public int PlayerId { get; set; }

        
        public int Score { get; set; }

        public DateTime Date { get; set; }

        public Game Game { get; set; }

        public Player Player { get; set; }
    }
}
