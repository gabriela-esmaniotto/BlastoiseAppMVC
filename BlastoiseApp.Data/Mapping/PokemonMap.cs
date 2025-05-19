
namespace BlastoiseApp.Data.Mapping
{
	public class PokemonMap : IEntityTypeConfiguration<Pokemon>
	{
		public void Configure(EntityTypeBuilder<Pokemon> builder)
		{
			builder.ToTable(nameof(Pokemon), t => t.HasComment("Tabela de registro dos pokémons"));
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired().HasComment("Nome do pokémon");
			builder.Property(x => x.Code).IsRequired().HasComment("Código do pokémon");
		}
	}
}
