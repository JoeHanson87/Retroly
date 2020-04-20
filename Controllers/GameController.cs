using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retroly.Models;

namespace Retroly.Controllers
{
    public class GameController : Controller
    {
        List<Game> GamesList = new List<Game>
        {
            new Game {Id = 1, Name = "Sonic The Hedgehog" },
            new Game {Id = 2, Name = "Cool Spot"},
            new Game {Id = 3, Name = "Golden Axe"}
        };

        // GET: Game
        public ActionResult Index()
        {
            return View(GamesList);
        }
    
        //GET: Game/Details
        public ActionResult Details(int id)
        {
            return View(id);
        }
    
    
    }



}