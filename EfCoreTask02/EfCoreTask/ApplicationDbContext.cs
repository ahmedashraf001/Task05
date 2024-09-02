using EfCoreTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask
{
	public class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer(@"Data Source=.; Initial Catalog=EfCoreTask; Integrated Security = True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>()
				.HasIndex(b => b.CreatedAt);

			modelBuilder.Entity<Customer>()
				.HasIndex(b=> new {b.FirstName , b.LastName});

			modelBuilder.Entity<User>()
				.HasIndex(b => b.Email)
				.IsUnique();

			modelBuilder.Entity<Product>()
				.HasIndex(b => b.ProductName)
				.HasDatabaseName("IX_ProductName")
				.HasFilter("[IsActive] = 1");

			modelBuilder.HasSequence("OrderNumberSeq")
				.StartsAt(100)
				.IncrementsBy(1);

			modelBuilder.Entity<Order>()
				.Property(b => b.OrderNumber)
				.HasDefaultValueSql("Next value for OrderNumberSeq ");

			modelBuilder.Entity<Role>()
				.HasData(
				   new Role {RoleId=1 ,  RoleName = "Admin" },
				   new Role { RoleId = 2,  RoleName = "User" },
				   new Role { RoleId = 3,  RoleName = "Guest" }
				);
			 

		}
		public DbSet<Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Role>Roles { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Customer> Customers { get; set; }





	}
}
