using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Highscores.Data.Entities
{
    public class Highscore
    {
        public Highscore(int gameId, int playerId, int score, DateTime date)
        {
            GameId = gameId;
            PlayerId = playerId;
            Score = score;
            Date = date;
        }

        public Highscore(int gameId, int playerId, int score, DateTime date, Game game, Player player)
        {
            GameId = gameId;
            PlayerId = playerId;
            Date = date;
            Score = score;
            Game = game;
            Player = player;
        }

        public int GameId { get; set; }

        public int PlayerId { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        [DataType(DataType.Date)] // vrem decat data adica data de calendar fara ore si minute!
        public DateTime Date { get; set; }

        public Game Game { get; set; }

        public Player Player { get; set; }
    }
}
