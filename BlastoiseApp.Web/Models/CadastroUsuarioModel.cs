using System.ComponentModel.DataAnnotations;

namespace BlastoiseApp.Web.Models
{
	public class CadastroUsuarioModel
	{
		[Display(Name ="Nome Completo")]
		[Required(ErrorMessage ="O {0} é obrigatório")]
		public string NomeCompleto { get; set; }


		[Display(Name ="E-mail")]
		[Required(ErrorMessage ="O {0} é obrigatório")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }


		[Required(ErrorMessage ="A {0} é obrigatória")]
		[DataType(DataType.Password)]
		public string Senha { get; set; }

	}
}
