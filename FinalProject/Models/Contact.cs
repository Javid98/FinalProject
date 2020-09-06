﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Contact
	{
		public int Id { get; set; }
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
		public DateTime Date { get; set; }
		public bool Read { get; set; } = false;
	}
}