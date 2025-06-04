using Microsoft.AspNetCore.Mvc;

namespace BlastoiseApp.Web.Controllers
{
	public class TesteController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SalvarUsuario(CadastroUsuarioModel model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index", "Teste");
			} else
			{
				return View("Index", model);
			}
		}
	}
}
