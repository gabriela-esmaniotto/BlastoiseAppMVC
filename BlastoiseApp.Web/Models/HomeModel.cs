using BlastoiseApp.Domain.DTOs.Pokemons;

namespace BlastoiseApp.Web.Models
{
	public class HomeModel
	{
		public string TextoInicio { get; set; }
		public List<PokemonListDTO> ListaPokemon { get; set; }

		public List<CardHome> ListaCard { get; set; }

	}
}
