using Highscores.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscores.Areas.API.Models
{
    public class CreateHighscoreDto
    {
        CreateHighscoreDto() { }
        public CreateHighscoreDto(int gameId, int playerId, int score, DateTime date)
        {
            GameId = gameId;
            PlayerId = playerId;
            Score = score;
            Date = date;
        }
        [Required]
        public int GameId { get; set; }
        [Required]
        public int PlayerId { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        [DataType(DataType.Date)] // Only the date without day & minutes
        public DateTime Date { get; set; }

        public Game Game { get; set; }

        public Player Player { get; set; }
    }
}
