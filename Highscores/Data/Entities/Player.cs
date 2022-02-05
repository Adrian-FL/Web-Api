using Highscores.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Highscores.Data.Entities
{
    public class Player
    { 
        public Player () { }

        public Player(int id, string name, string urlSlug)
        {
            Id = id;
            Name = name;
            UrlSlug = urlSlug;
        }

        public Player(string name)
        {
            Name = name;
            UrlSlug = name.Slugify();
        }

        public int Id { get; protected set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; protected set; }

        [Required]
        [MaxLength(50)]
        public string UrlSlug { get; protected set; }

       public ICollection<Highscore> Highscores { get; protected set; }
    }
}
