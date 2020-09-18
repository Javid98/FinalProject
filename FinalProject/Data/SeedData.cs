using FinalProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
	public class SeedData
	{
		static public void Initial(IApplicationBuilder builder)
		{
			using (var scope = builder.ApplicationServices.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				InitialBio(db);
				InitialPublisher(db);
				InitialBook(db);
				InitialBookFeature(db);
				InitialCategory(db);
				InitialBookCategory(db);
			}
		}


		private static void InitialBio(ApplicationDbContext db)
		{
			if (!db.Bios.Any())
			{
				db.Bios.Add(new Bio
				{
					PhoneNumber = "+994505550415",
					Logo = "c48d31b7-9213-4bed-b6af-2639383b159ebakumoz.png",
					FirstPublisherImage = "8e660003-02e5-4621-9854-1d5bb0fedb7bpublisherDiscount.jpg",
					SecondPublisherImage = "f5023347-3ebc-4f3d-b8e0-43b9ddbfb07bsale.jpg",
					InstagramLink = "https://www.instagram.com/bakumozbooks/?hl=en",
					FacebookLink = "https://www.facebook.com/bakumozbooks",
					Gmail = "booksbakumoz@gmail.com",
					Country = "Azərbaycan",
					City = "Baku",
					Street = "Molla Vəli Vidadi 148",
					Currency = 0.3M,
				});
				db.SaveChanges();
			}
		}

		private static void InitialPublisher(ApplicationDbContext db)
		{
			if (!db.Publishers.Any())
			{
				db.Publishers.Add(new Publisher
				{
					Slug = "pegasus",
					Name = "Pegasus",
					BookCount = 1,
					Discount = 0
				});
				db.SaveChanges();
			}
		}

		private static void InitialBook(ApplicationDbContext db)
		{
			if (!db.Books.Any())
			{
				db.Books.Add(new Book
				{
					Slug = "otuz-milyon-kelime",
					ImagePath = "4421f5fe-4cb6-40a8-a963-b114cdcff87dotuzmilyonkelime.jpg",
					Name = "Otuz Milyon Kelime",
					Description = "Test",
					Price = 30.5M,
					Count = 0,
					SaleCount = 0,
					PublisherId = db.Publishers.FirstOrDefault().Id
				});
				db.SaveChanges();
			};
		}

		private static void InitialBookFeature(ApplicationDbContext db)
		{
			if (!db.BookFeatures.Any())
			{
				db.BookFeatures.Add(new BookFeature
				{
					PublishingDate = DateTime.Now,
					PublishingLanguage = "Türkcə",
					OriginalLanguage = "İngiliscə",
					BookId = db.Books.FirstOrDefault().Id
				});
				db.SaveChanges();
			}
		}

		private static void InitialCategory(ApplicationDbContext db)
		{
			if (!db.Categories.Any())
			{
				db.Categories.Add(new Category
				{
					Slug = "usaq-ve-yeniyetmeler-ucun",
					Name = "Uşaq və yeniyetmələr üçün"
				});
				db.SaveChanges();
			}
		}

		private static void InitialBookCategory(ApplicationDbContext db)
		{
			if (!db.BookCategories.Any())
			{
				db.BookCategories.Add(new BookCategory
				{
					BookId = db.Books.FirstOrDefault().Id,
					CategoryId = db.Categories.FirstOrDefault().Id
				});
				db.SaveChanges();
			}
		}
	}
}
