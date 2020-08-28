using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class HomeVM
	{
		public ICollection<Book> Books { get; set; }
		public ICollection<Author> Authors { get; set; }
		public ICollection<Publisher> Publishers { get; set; }
	}
}
