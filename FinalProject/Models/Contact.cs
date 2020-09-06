using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Contact
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Ad daxil edin")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Soyad daxil edin")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Email daxil edin"), EmailAddress, DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required(ErrorMessage = "Nömrə daxil edin")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Mesaj daxil edin")]
		public string Message { get; set; }
		public DateTime Date { get; set; }
		public bool Read { get; set; } = false;
	}
}
