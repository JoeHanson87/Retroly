using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retroly.Models;
using Retroly.ViewModels;
using System.Data.Entity;

namespace Retroly.Controllers
{
    public class GameController : Controller
    {
        private ApplicationDbContext _context;

        public GameController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new GameFormViewModel()
            {
                Game = new Game(),
                Genre = genres
            };
            return View("GameForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Game game)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new GameFormViewModel
                {
                    Game = game,
                    Genre = _context.Genres.ToList()
                };

                return View("GameForm", viewModel);
            }

            if (game.Id == 0)
            { 
            game.DateAdded = DateTime.Now;
            _context.Games.Add(game);
            }
            else
            {
                var gameInDb = _context.Games.Single(c => c.Id == game.Id);

                gameInDb.Name = game.Name;
                gameInDb.ReleaseDate = game.ReleaseDate;
                gameInDb.GenreId = game.GenreId;
                gameInDb.NumInStock = game.NumInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Game");
        }
        // GET: Game
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageGames))
                return View("List");
            else
                return View("ReadOnlyList");
        }
    
        //GET: Game/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("Game ID not found");
            }
            return View(_context.Games.Include(c => c.Genre).FirstOrDefault(game => game.Id == id));
        }
        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(c => c.Id == id);

            if (game == null)
                return HttpNotFound();

            var viewModel = new GameFormViewModel
            {
                Game = game,
                Genre = _context.Genres.ToList()
            };

            return View("GameForm", viewModel);
        }
    }
}