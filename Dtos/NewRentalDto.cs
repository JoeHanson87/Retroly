using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retroly.Dtos
{
    public class NewRentalDto
    {
        public List<int> GameIds { get; set; }
        public int CustomerId { get; set; }
    }
}