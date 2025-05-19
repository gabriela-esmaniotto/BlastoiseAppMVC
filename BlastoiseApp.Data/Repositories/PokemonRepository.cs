
namespace BlastoiseApp.Data.Repositories
{
	public class PokemonRepository : RepositoryBase<Pokemon>, IPokemonRepository
	{
		public PokemonRepository(BlastoiseAppDbContext context) : base(context)
		{
		}
	}
}
