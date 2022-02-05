using Highscores.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Highscores.Data.Entities
{
    public class Game
    { 
        public Game(int id, string name, string description, string genre, int releaseYear, Uri imageUrl, string urlSlug)
        {
            Id = id;
            Name = name;
            Description = description;
            Genre = genre;
            ReleaseYear = releaseYear;
            UrlSlug = urlSlug;
            ImageUrl = imageUrl;
        }
        public Game(string name, string description, int releaseYear, Uri imageUrl)
        {
            Name = name;
            Description = description;
            ReleaseYear = releaseYear;
            UrlSlug = name.Slugify();
            ImageUrl = imageUrl;
        }

        public Game(int id, string name, string description, int releaseYear, Uri imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            ReleaseYear = releaseYear;
            UrlSlug = name.Slugify();
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public string Genre { get; protected set; }

        public int ReleaseYear { get; protected set; }

        public Uri ImageUrl { get; protected set; }

        [Required]
        [MaxLength(50)]
        public string UrlSlug { get; protected set; }

        public ICollection<Highscore> Highscores { get; set; }
    }
}
