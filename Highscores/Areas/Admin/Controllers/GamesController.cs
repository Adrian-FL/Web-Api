using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Highscores.Data;
using Highscores.Data.Entities;
using Highscores.Areas.Admin.Models.ViewModels;
using System.Diagnostics;

namespace Highscores.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GamesController : Controller
    {
        private readonly HighscoresContext _context;

        public GamesController(HighscoresContext context)
        {
            _context = context;
        }

        // GET: Admin/Games
        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }

        // GET: Admin/Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Admin/Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameView viewModel)
        {
            
            Game game;
            if (ModelState.IsValid)
            {
                
                Debug.WriteLine(viewModel.Name);
                game = new Game(
                    viewModel.Name,
                    viewModel.Description,
                    viewModel.ReleaseYear,
                    viewModel.ImageUrl
                );
                //game.Highscores = context.Highscores.Include(h => h.Player).Where(highscore => highscore.GameId == game.Id).OrderByDescending(highscore => highscore.Score).ToList();
                _context.Add(game);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Admin/Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Admin/Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Genre,ReleaseYear,ImageUrl,UrlSlug")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Admin/Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Admin/Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }
    }
}
