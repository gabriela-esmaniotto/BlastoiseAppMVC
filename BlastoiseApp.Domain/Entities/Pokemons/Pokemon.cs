namespace BlastoiseApp.Domain.Entities.Pokemons
{
	public class Pokemon : BaseEntity
	{
		[MaxLength(100)]
		public string Name { get; private set; } = null!;
		public int Code { get; private set; }
	}
}
