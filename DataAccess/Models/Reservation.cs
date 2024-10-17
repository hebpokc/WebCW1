using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class Reservation
    {
        public Guid Id { get; set; }
        public Guid ComputerId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
