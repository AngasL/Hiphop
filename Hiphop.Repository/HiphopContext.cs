using Microsoft.EntityFrameworkCore;
using Hiphop.Repository.Model;
using Microsoft.Extensions.Configuration;

namespace Hiphop.Repository
{
	public class HiphopContext : DbContext
	{
		private readonly IConfigurationRoot _config;
		public HiphopContext(IConfigurationRoot config,
			DbContextOptions<HiphopContext> options)
			: base(options)
		{
			this._config = config;
		}

		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("User");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(_config["ConnectinoStrings:Hiphop"]);
		}
	}
}
