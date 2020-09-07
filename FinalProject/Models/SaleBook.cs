using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class SaleBook
	{
        public int Id { get; set; }
        public int Count { get; set; }
		[Range(0, 9999.99)]
        public decimal Price { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
