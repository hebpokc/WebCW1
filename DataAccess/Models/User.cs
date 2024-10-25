using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User : IdentityUser
    {
        public int? AdminId { get; set; }
        public Admin? Admin { get; set; }
        public Group? Group { get; set; }
        public int? GroupId { get; set; }
        public List<Reservation> Reservations { get; set; } = [];
    }
}
