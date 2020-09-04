using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class ContactVM
	{
        [Required]
		public string Name { get; set; }
		[Required]
		public string Surname { get; set; }
		[Required, EmailAddress, DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public string Message { get; set; }
		public Bio Bio { get; set; }
	}
}
