using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribeToNewLeter { get; set; }

        public byte MembershipTypeId { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}