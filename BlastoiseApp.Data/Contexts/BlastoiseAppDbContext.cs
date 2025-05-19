
using BlastoiseApp.Domain.Entities.Contacts;

namespace BlastoiseApp.Data.Contexts
{
	public class BlastoiseAppDbContext : DbContext
	{
		public BlastoiseAppDbContext(DbContextOptions<BlastoiseAppDbContext> dbContextOptions) : base(dbContextOptions) { }

		public DbSet<Pokemon> Pokemons { get; set; }
		public DbSet<Contact> Contacts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PokemonMap());
			modelBuilder.ApplyConfiguration(new ContactMap());
		}
	}
}
