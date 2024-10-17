using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public int UserId { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
        public string Status { get; set; } = string.Empty;
        public Computer? Computer { get; set; }
        public List<User> Users { get; set; } = [];
    }
}
