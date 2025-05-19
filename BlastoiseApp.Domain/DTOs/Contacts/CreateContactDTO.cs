namespace BlastoiseApp.Domain.DTOs.Contacts
{
	public class CreateContactDTO
	{
		[Display(Name="Nome")]
		public string Name { get; set; }
		[Display(Name="E-mail")]
		public string Email { get; set; }
		[Display(Name="Mensagem")]
		public string Message { get; set; }
	}
}
