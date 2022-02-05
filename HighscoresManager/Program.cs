using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using static System.Console;

namespace HighscoresManager
{
    partial class Program
    {
        static readonly HttpClient httpClient = new HttpClient();

        static void Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("https://localhost:5001");

            CursorVisible = false;
            bool applicationRunning = true;

            do
            {
                WriteLine("1. Register Highscore");
                WriteLine("2. List Games");
                WriteLine("3. Add game");
                WriteLine("4. Delete Game");
                WriteLine("5. Exit");

                ConsoleKeyInfo input = ReadKey(true);

                Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        RegisterHighscore();
                        break;

                    case ConsoleKey.D2:
                        ListGames();
                        WriteLine("..press any key to continue");
                        ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        AddGame();
                        break;

                    case ConsoleKey.D4:
                        DeleteGame();
                        break;

                    case ConsoleKey.D5:
                        applicationRunning = false;
                        break;
                }
                Thread.Sleep(2000);
                Clear();

            } while (applicationRunning);

        }

        private static void WriteAllGames(IEnumerable<Game> games)
        {
            Write("Available Games:");
            foreach (var game in games)
            {
                WriteLine("\t" + game.Name);
            }
        }
        private static void WriteAllPlayers(IEnumerable<Player> players)
        {
            Write("Available Players:");
            foreach (var player in players)
            {
                WriteLine("\t" + player.Name);
            }
        }
        private static void RegisterHighscore()
        {
            var responseGames = httpClient.GetAsync("api/games")
                 .Result;

            //  GET api/players/   with name get ListAllPlayers
            var responsePlayers = httpClient.GetAsync("api/players")
                 .Result;

            if (responseGames.IsSuccessStatusCode && responsePlayers.IsSuccessStatusCode)
            {
                var jsonString = responseGames.Content.ReadAsStringAsync()
                    .Result;

                var games = JsonConvert.DeserializeObject<IEnumerable<Game>>(jsonString);

                // CHOOSE GAME
                string name = "";
                Game game = null;
                bool gameFound = false;
                while (gameFound == false)
                {
                    WriteAllGames(games);
                    Write("Game: ");
                    name = ReadLine();

                    foreach (var g in games)
                    {
                        if (g.Name.Trim() == name.Trim())
                        {
                            gameFound = true;
                            game = g;
                            break;
                        }
                    }
                }

                // CHOOSE PLAYER
                var jsonStringPlayers = responsePlayers.Content.ReadAsStringAsync()
                    .Result;
                var players = JsonConvert.DeserializeObject<IEnumerable<Player>>(jsonStringPlayers);

                string playerName = "";
                Player player = null;
                bool playerFound = false;
                while (playerFound == false)
                {
                    WriteAllPlayers(players);
                    Write("Player: ");
                    playerName = ReadLine();

                    foreach (var p in players)
                    {
                        if (p.Name.Trim() == playerName.Trim())
                        {
                            playerFound = true;
                            player = p;
                            break;
                        }
                    }
                }
 
                // CHOOSE SCORE
                Write("Score: ");
                int score = Convert.ToInt32(ReadLine());

                // CHOOSE DATE
                string line;
                DateTime date;           
                do
                {
                    Write("Date: ");
                    line = ReadLine().Trim();
                } while (DateTime.TryParse(line, out date) == false);

                var payload = new Highscore
                (
                   game.Id,
                   player.Id,
                   score,
                   date
               );

                var stringPayload = JsonConvert.SerializeObject(payload);

                var httpContent = new StringContent(stringPayload, System.Text.Encoding.UTF8, "application/json");

                var createResponse = httpClient.PostAsync("api/highscores", httpContent)
                    .Result;

                if (createResponse.IsSuccessStatusCode)
                {
                    WriteLine("Highscore added");
                }
                else
                {
                    WriteLine("Invalid Request sent to server.");
                }
            }
            else
            {
                WriteLine("Couldn't fetch games or players.");
            }
        }

        private static void DeleteGame()
        {
            Write("ID:");
            var id = Convert.ToInt32(ReadLine());

            DeleteGameById(id);
        }
        private static void DeleteGameById(int id)
        {
            var response = httpClient.DeleteAsync($"api/games/{id}")
                .Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync()
                    .Result;

                WriteLine(result);
            }
        }

        private static void AddGame()
        {
            string yesNo = "N";
            string title;
            string description;
            int releaseYear;
            string imageUrl;
            do
            {
                Write("Title:");
                title = Console.ReadLine();
                Write("Description:");
                description = Console.ReadLine();
                Write("Release Year:");
                releaseYear = Convert.ToInt32(Console.ReadLine());
                Write("Image Url:");
                imageUrl = Console.ReadLine();
                Write("Is this correct? (Y / N):");

                yesNo = Console.ReadLine();
            } while (yesNo.ToUpper().Trim() != "Y");

            // make POST request with the data to api/games
            var payload = new Game
            (
                title,
                description,
                releaseYear,
                imageUrl
            );

            var stringPayload = JsonConvert.SerializeObject(payload);

            var httpContent = new StringContent(stringPayload, System.Text.Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("api/games", httpContent)
                .Result;

            if (response.IsSuccessStatusCode)
            {
                WriteLine("Game added");
            }
            else
            {
                WriteLine("Invalid Request sent to server.");
            }

            Thread.Sleep(2000);
        }

        private static void ListGames()
        {
            var response = httpClient.GetAsync("api/games")
                 .GetAwaiter()
                 .GetResult();

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync()
                    .Result;

                var games = JsonConvert.DeserializeObject<IEnumerable<Game>>(jsonString);

                WriteLine("ID".PadRight(5) + "Title".PadRight(12) + "Description".PadRight(15) + "Year".PadRight(10) + "Genre".PadRight(12)); /*+ "Image Url".PadRight(26)) ;*/
                WriteLine("".PadRight(74, '-'));
                foreach (var game in games)
                {
                    var id = $"{game.Id}.".PadRight(5, ' ');                        // 5 chars


                    var title = (game.Name.Length < 10 ?
                            game.Name :
                            $"{game.Name.Substring(0, 10)}.."
                        ).PadRight(12, ' ');                                        // 12 chars in description

                    var desc = (game.Description.Length < 10 ?
                            game.Description :
                            $"{game.Description.Substring(0, 10)}.."
                        ).PadRight(12, ' ');                                        // 12 chars in title

                    var releaseYear = $"\t{game.ReleaseYear}".PadRight(7, ' ');     // 7  chars for release year
                    var genre = $"\t{game.Genre}".PadRight(12, ' ');                // 12 chars for the genre
                    //var imageUrl = $"\t{game.ImageUrl}".PadRight(26, ' ');         // 26 chars for the uri

                    WriteLine(

                        id + title + desc + releaseYear + genre
                        //+ imageUrl
                        );
                }
            }
        }
    }
}