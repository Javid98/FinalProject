using FinalProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class ProfileVM
	{
		public ICollection<SaleBook> SaleBooks { get; set; }
		public UserDetail UserDetail { get; set; }
		public AppUser AppUser { get; set; }
		public ICollection<FavoriteBook> FavoriteBooks { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<Publisher> Publishers { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
		public DateTime BirthDay { get; set; }
		public IFormFile Photo { get; set; }
	}
}
