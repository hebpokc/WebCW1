using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string GPU { get; set; } = string.Empty;
        public string CPU {  get; set; } = string.Empty;
        public int RAM { get; set; }
        public double Price { get; set; }
    }
}
