using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Publisher
	{
		public int Id { get; set; }
		public string Slug { get; set; }
		[Required]
		public string Name { get; set; }
		public int BookCount { get; set; } = 0;
		public ICollection<Book> Books { get; set; }
	}
}
