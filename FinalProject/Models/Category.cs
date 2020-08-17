﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Slug { get; set; }
		public string Name { get; set; }
		public ICollection<BookCategory> BookCategories { get; set; }
	}
}
