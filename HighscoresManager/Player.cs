namespace HighscoresManager
{
    public class Player
    {
        public Player() { }
        public Player(int id, string name, string urlSlug)
        {
            Id = id;
            Name = name;
            UrlSlug = urlSlug;
        }

        public Player(string name)
        {
            Name = name;
        }

        public int Id { get;  set; }

        public string Name { get;  set; }

        public string UrlSlug { get;  set; }
    }
}