﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class AppUser:IdentityUser
	{
        [Required,StringLength(50)]
		public string FullName { get; set; }
		public bool IsBlocked { get; set; } = false;
		public ICollection<SaleBook> Purchases { get; set; }
		public virtual UserDetail UserDetail { get; set; }
	}
}