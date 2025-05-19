namespace BlastoiseApp.Web.Models
{
	public class HomeModel
	{
		public string TextoInicio { get; set; }
		public List<PokemonHomeModel> ListaPokemon { get; set; }

		public List<CardHome> ListaCard { get; set; }

	}

	public class PokemonHomeModel
	{
		public string Nome { get; set; }
		public string Codigo { get; set; }
		public string LinkImagem { get; set; }
	}
}
