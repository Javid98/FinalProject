using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class NewBooksVM
	{
		public ICollection<Book> Books { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<Author> Authors { get; set; }
		public ICollection<Publisher> Publishers { get; set; }
	}
}
