namespace BlastoiseApp.Domain.Interfaces.Services
{
	public interface IPokemonService
	{
		Task<List<PokemonListDTO>> GetAllAsync();
		Task<UpdatePokemonDTO?> GetByIdAsync(int id);
		Task<(bool success, string? errorMessage)> CreateAsync(CreatePokemonDTO model);
		Task<(bool success, string? errorMessage)> UpdateAsync(UpdatePokemonDTO model);
		Task<(bool success, string? errorMessage)> DeleteByIdAsync(int id);
	}
}
