using System;
using System.ComponentModel.DataAnnotations;

namespace HighscoresManager
{

    public class Highscore
    {
        public Highscore() { }
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
            Score = score;
            Date = date;
            Game = game;
            Player = player;

        }
        public int GameId { get; set; }

        public int PlayerId { get; set; }


        public int Score { get; set; }
        [DataType(DataType.Date)] //only date- without hours and min
        public DateTime Date { get; set; }

        public Game Game { get; set; }

        public Player Player { get; set; }
    }


}