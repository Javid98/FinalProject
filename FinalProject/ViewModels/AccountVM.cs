using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
	public class AccountVM
	{
        [Required(ErrorMessage = "Ad, soyad daxil edin"), StringLength(50, ErrorMessage = "Uzunluq maksimum 50 simvol ola bilər")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Username daxil edin"), StringLength(30, ErrorMessage = "Uzunluq maksimum 30 simvol ola bilər")]
        public string RegisterUsername { get; set; }
        [Required(ErrorMessage = "Username daxil edin"), StringLength(30, ErrorMessage = "Uzunluq maksimum 30 simvol ola bilər")]
        public string LoginUsername { get; set; }
        [Required(ErrorMessage = "Email daxil edin"), EmailAddress(ErrorMessage ="Düzgün email daxil edin"), DataType(DataType.EmailAddress, ErrorMessage = "Düzgün email daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə daxil edin"), DataType(DataType.Password)]
        public string RegisterPassword { get; set; }
        [Required(ErrorMessage = "Şifrə daxil edin"), DataType(DataType.Password)]
        public string LoginPassword { get; set; }
        [Required(ErrorMessage = "Şifrə daxil edin"), Compare(nameof(RegisterPassword),ErrorMessage ="Şifrələr uyğun gəlmir"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public bool IsChecked { get; set; }
        public Bio Bio { get; set; }
    }
}
