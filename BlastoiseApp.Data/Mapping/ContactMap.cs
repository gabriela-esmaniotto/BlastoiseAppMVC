
using BlastoiseApp.Domain.Entities.Contacts;

namespace BlastoiseApp.Data.Mapping
{
	public class ContactMap : IEntityTypeConfiguration<Contact>
	{
		public void Configure(EntityTypeBuilder<Contact> builder)
		{
			builder.ToTable(nameof(Contact), t => t.HasComment("Tabela de registro dos contatos"));
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired().HasComment("Nome do contato");
			builder.Property(x => x.Email).IsRequired().HasComment("E-mail do contato");
			builder.Property(x => x.Message).IsRequired().HasComment("Mensagem do contato");
		}
	}
}
