using Highscores.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Highscores.Models.ViewModels
{
    public class CreateHighscoreViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Game { get; set; }

        [Required]
        [MaxLength(50)]
        public string Player { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Score { get; set; }

        public List<Game> Games { get; set; }
    }
}
