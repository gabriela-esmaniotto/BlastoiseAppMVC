namespace BlastoiseApp.Domain.DTOs.Pokemons
{
	public class PokemonListDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int Code { get; set; }
		public bool Active { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
