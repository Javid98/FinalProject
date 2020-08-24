using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
	public class ApplicationDbContext : IdentityDbContext<AppUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<BookFeature> BookFeatures { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<BookCategory> BookCategories { get; set; }
		public DbSet<BookAuthor> BookAuthors { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<SaleBook> SaleBooks { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }
		public DbSet<FavoriteBook> FavoriteBooks { get; set; }
	}
}
