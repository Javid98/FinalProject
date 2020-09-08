using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Slug { get; set; }
		[Required]
		public string ImagePath { get; set; }
		[Required(ErrorMessage = "Kitabın adını daxil edin")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Kitab haqqında məlumat daxil edin")]
		public string Description { get; set; }
		[Required(ErrorMessage = "Qiymət daxil edin")]
		public decimal Price { get; set; }
		[Required(ErrorMessage = "Say daxil edin")]
		public int Count { get; set; }
		public int SaleCount { get; set; }
		public int PublisherId { get; set; }
		public Publisher Publisher { get; set; }
		public virtual BookFeature BookFeature { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
		public ICollection<SaleBook> SaleBooks { get; set; }
		public ICollection<FavoriteBook> FavoriteBooks { get; set; }
		public ICollection<BookInCart> BookInCarts { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
	}
}