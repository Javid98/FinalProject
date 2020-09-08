using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class UserDetail
	{
		public int Id { get; set; }
		public string ImagePath { get; set; }
		[DataType(DataType.Date,ErrorMessage ="Tarix qeyd edin")]
		[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Birthday { get; set; }
		public string Gender { get; set; }
		public string PhoneNumber { get; set; }
		public string InstagramLink { get; set; }
		public string FacebookLink { get; set; }
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
	}
}
