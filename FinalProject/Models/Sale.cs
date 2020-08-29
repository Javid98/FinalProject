using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Sale
	{
		public int Id { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime Date { get; set; }
		public string DeliveryType { get; set; }
		public string DeliveryLocation { get; set; }
		public double Total { get; set; }
		public string PhoneNumber { get; set; }
		public bool Completed { get; set; } = false;
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }
		public ICollection<SaleBook> SaleBooks { get; set; }
	}
}
