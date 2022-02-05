using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Highscores.Areas.API.Models
{
    public class CreateGameDto
    {
        [Required]
        [MaxLength(50)]
        public string Name{ get; set; }
        [Required]
        [MaxLength (250)]
        public string Description { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
