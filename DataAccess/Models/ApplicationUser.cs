using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class ApplicationUser : IdentityUser
    {
        public Guid AdminId { get; set; }
        public Admin? Admin { get; set; }
        public List<Group> Groups { get; set; } = [];
    }
}
