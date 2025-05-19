
namespace BlastoiseApp.Application.Services
{
	public class PokemonService : IPokemonService
	{
		private readonly IPokemonRepository _pokemonRepository;

		public PokemonService(IPokemonRepository pokemonRepository)
		{
			_pokemonRepository = pokemonRepository;
		}

		public async Task<List<PokemonListDTO>> GetAllAsync()
		{
			var pokemons = await _pokemonRepository.GetAllAsync();

			return pokemons.Adapt<List<PokemonListDTO>>();
		}

		public async Task<(bool success, string? errorMessage)> CreateAsync(CreatePokemonDTO model)
		{
			if (await _pokemonRepository.AnyAsync(x => x.Name.Equals(model.Name)))
				return (false, "Já existe um pókémon com este nome.");

			if (await _pokemonRepository.AnyAsync(x => x.Code == model.Code))
				return (false, "Já existe um pókémon com este código.");

			var pokemon = model.Adapt<Pokemon>();

			await _pokemonRepository.CreateAsync(pokemon);

			return (true, null);
		}


		public async Task<UpdatePokemonDTO?> GetByIdAsync(int id)
		{
			var pokemon = await _pokemonRepository.GetByIdAsync(id);

			return pokemon?.Adapt<UpdatePokemonDTO>();
		}


		public async Task<(bool success, string? errorMessage)> UpdateAsync(UpdatePokemonDTO model)
		{
			if (await _pokemonRepository.AnyAsync(x => x.Id != model.Id && x.Name.Equals(model.Name)))
				return (false, "Já existe um pókémon com este nome.");

			if (await _pokemonRepository.AnyAsync(x => x.Id != model.Id && x.Code == model.Code))
				return (false, "Já existe um pókémon com este código.");

			var pokemon = model.Adapt<Pokemon>();

			await _pokemonRepository.UpdateAsync(pokemon);

			return (true, null);
		}

		public async Task<(bool success, string? errorMessage)> DeleteByIdAsync(int id)
		{
			var pokemon = await _pokemonRepository.GetByIdAsync(id);

			if (pokemon == null)
				return (false, "Pókémon não encontrado.");

			await _pokemonRepository.DeleteAsync(pokemon);

			return (true, null);
		}
	}
}
