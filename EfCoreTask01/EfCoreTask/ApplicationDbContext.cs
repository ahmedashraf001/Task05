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
			modelBuilder.Entity<Student>()
				.Property(b => b.Age)
				.HasDefaultValue(22)
				.HasComment("Name of the student");


			modelBuilder.Entity<Student>()
				.Property(b => b.ID_Age)
				.HasComputedColumnSql("[StId] + [Age]");
 
			modelBuilder.Entity<instructor>()
				.HasKey(b => new { b.ins_Key, b.ins_ID });

			modelBuilder.Entity<Blog>()
				.HasOne(b => b.BlogImage)
				.WithOne(b => b.Blog);

			modelBuilder.Entity<Blog>()
				.HasMany(b => b.Posts)
				.WithOne(b => b.Blog);


			modelBuilder.Entity<Post>()
				.HasMany(b => b.Tags)
				.WithMany(b => b.Posts)
				.UsingEntity<Post_Tag>(
					b => b
					   .HasOne(b => b.Tag)
					   .WithMany(b => b.Post_Tags)
					   .HasForeignKey(b => b.Tag_Id),
					b => b
					   .HasOne(b => b.Post)
					   .WithMany(b => b.Post_Tags)
					   .HasForeignKey(b => b.Post_Id),

					b =>
					{
						b.HasKey(b => new { b.Post_Id, b.Tag_Id });
						b.ToTable("Post_Tag_Third_Table");
						b.Property(b => b.Date).HasDefaultValueSql("getdate()");
					}




				);


		}
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<instructor> Instructors { get; set; }


	}
}
