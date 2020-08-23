using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class UserDetail
	{
		public int Id { get; set; }
		public int Age { get; set; }
		public string PhoneNumber { get; set; }
		public string InstagramLink { get; set; }
		public string FacebookLink { get; set; }
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }
	}
}
