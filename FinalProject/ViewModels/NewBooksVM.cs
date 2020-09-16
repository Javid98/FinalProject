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
		public ICollection<Book> AllBooks { get; set; }
		public Book Book { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<BookAuthor> rBookAuthors { get; set; }
		public ICollection<BookCategory> rBookCategories { get; set; }
		public ICollection<Author> Authors { get; set; }
		public ICollection<Publisher> Publishers { get; set; }
		public Publisher Publisher { get; set; }
		public ICollection<Category> Categories { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
		public ICollection<BookInCart> BookInCarts { get; set; }
		public ICollection<FavoriteBook> FavoriteBooks { get; set; }
		public BookFeature BookFeature { get; set; }
		public Bio Bio { get; set; }
	}
}
