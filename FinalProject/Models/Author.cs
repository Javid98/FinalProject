using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string Slug { get; set; }
		[Required]
		public string Fullname { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }

	}
}
