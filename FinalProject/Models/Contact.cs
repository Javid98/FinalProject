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
		[Required(ErrorMessage = "Ad yazın")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Soyad yazın")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Email yazın"), EmailAddress(ErrorMessage = "Düzgün email yazın"), DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required(ErrorMessage = "Nömrə yazın")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Mesaj yazın")]
		public string Message { get; set; }
		public DateTime Date { get; set; }
		public bool Read { get; set; } = false;
	}
}
