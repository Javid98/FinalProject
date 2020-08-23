using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Sale
	{
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
