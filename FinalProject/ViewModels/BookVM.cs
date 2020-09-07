using FinalProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class BookVM
	{
		public string Slug { get; set; }
		[Required]
		public string ImagePath { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		[Range(0, 9999.99)]
		public decimal Price { get; set; }
		[Required]
		public int Count { get; set; }

		public string PublishingPlace { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
		public DateTime PublishingDate { get; set; }
		public string PublishingLanguage { get; set; }
		public string OriginalLanguage { get; set; }
		public string Translator { get; set; }


		public Book Book { get; set; }
		public ICollection<Author> Authors { get; set; }
		public ICollection<Category> Categories { get; set; }
		public ICollection<Publisher> Publishers { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
	}
}
