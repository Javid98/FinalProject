using FinalProject.Models;
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
		[DataType(DataType.Date)]
		public DateTime BirthDay { get; set; }
	}
}
