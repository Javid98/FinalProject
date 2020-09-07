using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class UserVM
	{
		public string Id { get; set; }
		public string Fullname { get; set; }
		public string Username { get; set; }
		public string Role { get; set; }
		public Bio Bio { get; set; }
	}
}
