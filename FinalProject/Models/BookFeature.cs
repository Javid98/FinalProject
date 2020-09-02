using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class BookFeature
	{
		public int Id { get; set; }
		public string PublishingPlace { get; set; }
		[DataType(DataType.Date)]
		public DateTime PublishingDate { get; set; }
		public string PublishingLanguage { get; set; }
		public string OriginalLanguage { get; set; }
		public string Translator { get; set; }
		public int BookId { get; set; }
		public Book Book { get; set; }
	}
}
