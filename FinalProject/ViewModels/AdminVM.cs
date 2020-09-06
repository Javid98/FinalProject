using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class AdminVM
	{
		public List<Contact> Contacts { get; set; }
		public List<Sale> Sales { get; set; }
	}
}
