using BlastoiseApp.Domain.DTOs.Pokemons;
using System.Threading.Tasks;

namespace BlastoiseApp.Web.Controllers
{
	public class PokemonController : Controller
	{
		private readonly IPokemonService _pokemonService;

		public PokemonController(IPokemonService pokemonService)
		{
			_pokemonService = pokemonService;
		}

		public async Task<IActionResult> Index()
		{
			List<PokemonListDTO> pokemons = await _pokemonService.GetAllAsync();

			return View(pokemons);
		}

		public IActionResult Create()
		{
			var model = new CreatePokemonDTO() { Active = true };

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CreatePokemonDTO model)
		{
			try
			{
				if (!ModelState.IsValid)
					return View(model);

				var (success, errorMessage) = await _pokemonService.CreateAsync(model);

				if (!success)
				{
					TempData["ErrorMessage"] = errorMessage;
					return View(model);
				}

				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				TempData["ErrorMessage"] = "Não foi possível cadastrar o pokémon. Tente novamente mais tarde.";
				return View(model);
			}
		}


		public async Task<IActionResult> Edit(int id)
		{
			var model = await _pokemonService.GetByIdAsync(id);

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(UpdatePokemonDTO model)
		{
			try
			{
				if (!ModelState.IsValid)
					return View(model);

				var (success, errorMessage) = await _pokemonService.UpdateAsync(model);

				if (!success)
				{
					TempData["ErrorMessage"] = errorMessage;
					return View(model);
				}

				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				TempData["ErrorMessage"] = "Não foi possível editar o pokémon. Tente novamente mais tarde.";
				return View(model);
			}
		}


		public async Task<IActionResult> Delete(int id)
		{
			var (success, errorMessage) = await _pokemonService.DeleteByIdAsync(id);

			return Json(new { success, errorMessage });
		}

	}
}
