using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Highscores.Areas.Admin.Models.ViewModels
{
    public class CreateGameView
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Display(Name = "Image URL")]
        public Uri ImageUrl { get; set; }
    }
}
