using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscores.Areas.API.Models
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string IamgeUrl { get; set; }
    }
}
