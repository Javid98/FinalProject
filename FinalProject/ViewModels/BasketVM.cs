using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class BasketVM
	{
		public ICollection<BookInCart> BookInCarts { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
	}
}
