using BlastoiseApp.Domain.DTOs.Contacts;
using Microsoft.AspNetCore.Mvc;
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
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SendContact(CreateContactDTO model)
		{
			await _contactService.CreateAsync(model);
			return RedirectToAction("Index");
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
			
			return View(model);
		}

	}

}
