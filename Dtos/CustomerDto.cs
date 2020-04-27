using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Retroly.Dtos;

namespace Retroly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }

        public MemershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }
}