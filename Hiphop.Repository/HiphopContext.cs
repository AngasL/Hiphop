using Microsoft.EntityFrameworkCore;
using Hiphop.Repository.Model;

namespace Hiphop.Repository
{
	public class HiphopContext : DbContext
	{
		public HiphopContext(DbContextOptions<HiphopContext> options)
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("User");
		}
	}
}
