namespace BlastoiseApp.Domain.DTOs.Pokemons
{
	public class CreatePokemonDTO
	{

		[Required(ErrorMessage = "O nome é obrigatório.")]
		[MaxLength(100, ErrorMessage = "O nome é obrigatório.")]
		[Display(Name = "Nome")]
		public string Name { get; set; } = null!;

		[Required(ErrorMessage = "O código é obrigatório.")]
		[Range(1, int.MaxValue, ErrorMessage = "O código precisa ser maior do que 0.")]
		[Display(Name = "Código")]
		public int? Code { get; set; }

		[Required]
		[Display(Name = "Ativo")]
		public bool Active { get; set; }
	}
}
