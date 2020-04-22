using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Retroly.Models;

namespace Retroly.ViewModels
{
    public class GameFormViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public Game Game { get; set; }
    }
}