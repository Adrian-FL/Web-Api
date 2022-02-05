using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Highscores.Data;
using Highscores.Data.Entities;
using System.Diagnostics;

namespace Highscores.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HighscoresController : Controller
    {
        private readonly HighscoresContext _context;

        public HighscoresController(HighscoresContext context)
        {
            _context = context;
        }

        // GET: Admin/Highscoress
        public async Task<IActionResult> Index()
        {
            List<Highscore> maxHighscores = new List<Highscore>();

            List<Game> games = await _context.Games.ToListAsync();
            List<Highscore> highscores = await _context.Highscores.ToListAsync();

            foreach (Game game in games)
            {
                Highscore maxHighscore = highscores.First();
                foreach (Highscore highscore in highscores)
                {
                    if (highscore.GameId == game.Id)
                    {
                        if (maxHighscore.Score < highscore.Score)
                        {
                            maxHighscore = highscore;
                        }
                    }
                }
                maxHighscore.Game = _context.Games.Where(x => x.Id == maxHighscore.GameId).FirstOrDefault();
                maxHighscore.Player = _context.Players.Where(x => x.Id == maxHighscore.PlayerId).FirstOrDefault();
                maxHighscores.Add(maxHighscore);
            }

            return View(maxHighscores);
        }

        // GET: Admin/Highscoress/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscores
                .Include(h => h.Game)
                .Include(h => h.Player)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (highscore == null)
            {
                return NotFound();
            }

            return View(highscore);
        }

        // GET: Admin/Highscoress/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "UrlSlug");
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Name");
            return View();
        }

        // POST: Admin/Highscoress/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,PlayerId,Score,Date")] Highscore highscore)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(highscore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "UrlSlug", highscore.GameId);
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Name", highscore.PlayerId);
            return View(highscore);
        }

        // GET: Admin/Highscoress/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscores.FindAsync(id);
            if (highscore == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "UrlSlug", highscore.GameId);
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Name", highscore.PlayerId);
            return View(highscore);
        }

        // POST: Admin/Highscoress/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameId,PlayerId,Score,Date")] Highscore highscore)
        {
            if (id != highscore.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(highscore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HighscoreExists(highscore.GameId))
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
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "UrlSlug", highscore.GameId);
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Name", highscore.PlayerId);
            return View(highscore);
        }

        // GET: Admin/Highscoress/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscores
                .Include(h => h.Game)
                .Include(h => h.Player)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (highscore == null)
            {
                return NotFound();
            }

            return View(highscore);
        }

        // POST: Admin/Highscoress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var highscore = await _context.Highscores.FindAsync(id);
            _context.Highscores.Remove(highscore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HighscoreExists(int id)
        {
            return _context.Highscores.Any(e => e.GameId == id);
        }
    }
}
