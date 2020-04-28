using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Retroly.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(0,99)]
        public int NumInStock { get; set; }
        public int NumAvailable { get; set; }
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}