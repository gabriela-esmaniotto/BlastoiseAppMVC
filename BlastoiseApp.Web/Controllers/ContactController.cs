using BlastoiseApp.Domain.DTOs.Contacts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Threading.Tasks;

namespace BlastoiseApp.Web.Controllers
{
	public class ContactController : Controller
	{

		private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
		{
			int valorSoma1 = 5;

			int valorSoma2 = 10;

			int resultadoSoma = valorSoma1 + valorSoma2;

			int valorMulti1 = 2;

			int valorMulti2 = 9;

			int resultadoMulti = valorMulti1 * valorMulti2;

			int valorSub1 = 12;

			int valorSub2 = 9;

			int resultadoSub = valorSub1 - valorSub2;

			return View();
		}

		private static void Subtrair()
		{
			int valorSub1 = 12;
			int valorSub2 = 9;
			int resultadoSub = valorSub1 - valorSub2;
		}

		private static void Multiplicar()
		{
			int valorMulti1 = 2;
			int valorMulti2 = 9;
			int resultadoMulti = valorMulti1 * valorMulti2;
		}

		private static void Somar()
		{
			int valorSoma1 = 5;
			int valorSoma2 = 10;
			int resultadoSoma = valorSoma1 + valorSoma2;
		}

		public IActionResult Teste()
		{
			TesteModel model = new TesteModel();
			model.Nome = "Gabriela";
			model.Idade = 25;
			model.Habilidades.Add("C#");
			model.Habilidades.Add("Python");
			model.Habilidades.Add("Java");
			model.Habilidades.Add("HTML");

			return RedirectToAction("Index", "Pokemon");
			//return View("Teste", model);
		}





















		[HttpPost]
		public async Task<IActionResult> SendContact(CreateContactDTO model)
		{
			await _contactService.CreateAsync(model);
			return RedirectToAction("Index");
		}

	}

}
