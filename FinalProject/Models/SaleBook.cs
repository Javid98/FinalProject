using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class SaleBook
	{
        public int Id { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
