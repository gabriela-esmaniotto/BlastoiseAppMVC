

namespace BlastoiseApp.Data.Repositories
{
	public class PokemonRepository : RepositoryBase<Pokemon>, IPokemonRepository
	{
		public PokemonRepository(BlastoiseAppDbContext context) : base(context)
		{
		}


		public override async Task<List<Pokemon>> GetAllAsync() =>
				await _context.Set<Pokemon>().OrderBy(x => x.Code).ToListAsync();
	}
}
