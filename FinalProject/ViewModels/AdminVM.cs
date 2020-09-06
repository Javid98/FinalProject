using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class AdminVM
	{
		public ICollection<Contact> Contacts { get; set; }
		public ICollection<Sale> Sales { get; set; }
		public Bio Bio { get; set; }
		public ICollection<AppUser> AppUsers { get; set; }
		public ICollection<IdentityRole> Roles { get; set; }
	}
}
