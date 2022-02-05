using System;

namespace HighscoresManager
{

    public class Game
    {
        public Game() {}
        public Game(string name, string description, int releaseYear, string imageUrl)
        {
            Name = name;
            Description = description;
            ReleaseYear = releaseYear;
            ImageUrl = new Uri(imageUrl);
        }
        public Game(string name, string description, int releaseYear, string genre, string imageUrl)
        {
            Name = name;
            Description = description;
            ReleaseYear = releaseYear;
            Genre = genre;
            ImageUrl = new Uri(imageUrl);
        }

        public Game(int id, string name, string description, int releaseYear, string genre, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            ReleaseYear = releaseYear;
            Genre = genre;
            ImageUrl = new Uri(imageUrl);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public Uri ImageUrl { get; set; }

    }


}