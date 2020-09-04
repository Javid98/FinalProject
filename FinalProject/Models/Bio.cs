using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Bio
	{
		public int Id { get; set; }
		public string PhoneNumber { get; set; }
		public string Logo { get; set; }
		public string InstagramLink { get; set; }
		public string FacebookLink { get; set; }
		public string Gmail { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public decimal Currency { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
	}
}
