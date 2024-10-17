using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class Computer
    {
        public Guid Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string GPU { get; set; } = string.Empty;
        public string CPU {  get; set; } = string.Empty;
        public int RAM { get; set; }
        public decimal Price { get; set; }
    }
}
