using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;

namespace Vidly_MVC.ViewModels
{
    public class CustometFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}