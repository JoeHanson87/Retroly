using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retroly.Models;
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

        // GET: Game
        public ActionResult Index()
        {
            var games = _context.Games.Include(c => c.Genre).ToList();
            return View(games);
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
    }



}