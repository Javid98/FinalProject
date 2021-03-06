﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Slug { get; set; }
		public string ImagePath { get; set; }
		[Required(ErrorMessage = "Zəhmət olmasa kateqoriyanın adını daxil edin")]
		public string Name { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
	}
}
