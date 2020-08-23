using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class AccountVM
	{
        [Required, StringLength(50)]
        public string Fullname { get; set; }
        [Required, StringLength(30)]
        public string RegisterUsername { get; set; }
        [Required, StringLength(30)]
        public string LoginUsername { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string RegisterPassword { get; set; }
        [Required, DataType(DataType.Password)]
        public string LoginPassword { get; set; }
        [Required, Compare(nameof(RegisterPassword)), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public bool IsChecked { get; set; }
    }
}
