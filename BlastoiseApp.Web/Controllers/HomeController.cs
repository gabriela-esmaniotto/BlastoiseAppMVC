using BlastoiseApp.Domain.DTOs.Pokemons;

namespace BlastoiseApp.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IPokemonService _pokemonService;

		public HomeController(ILogger<HomeController> logger, IPokemonService pokemonService)
		{
			_logger = logger;
			_pokemonService = pokemonService;
		}

		public async Task<IActionResult> Index()
		{

			HomeModel model = new HomeModel();

			model.TextoInicio = "Sua Aventura Pokemón Começa Aqui";

			List<PokemonListDTO> pokemons = await _pokemonService.GetAllAsync();
			model.ListaPokemon = pokemons;

			model.ListaCard = new List<CardHome>();

			CardHome primeiroCard = new CardHome();
			primeiroCard.Titulo = "Pocket Monsters";
			primeiroCard.Texto = "O nome “Pokémon” é uma abreviação de Pocket Monsters (\"monstros de bolso\"), como eram chamados no Japão no lançamento original.";
			model.ListaCard.Add(primeiroCard);

			CardHome segundoCard = new CardHome();
			segundoCard.Titulo = "+ 1.000 Pokémons";
			segundoCard.Texto = "Desde 1996, o número de Pokémon só cresceu. Com as gerações mais recentes, já passamos de 1.000 espécies diferentes!";
			model.ListaCard.Add(segundoCard);

			CardHome terceiroCard = new CardHome();
			terceiroCard.Titulo = "Guinness World Records";
			terceiroCard.Texto = "A franquia Pokémon tem vários recordes, incluindo o jogo de RPG mais vendido na história do entretenimento (Pokémon Red/Blue/Green).";
			model.ListaCard.Add(terceiroCard);

			CardHome quartoCard = new CardHome();
			quartoCard.Titulo = "MissingNo.";
			quartoCard.Texto = "Abreviação de “Missing Number” é um Pokémon glitched que aparece nos jogos Pokémon Red e Blue, resultado de falhas na programação.";
			model.ListaCard.Add(quartoCard);


			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}


		public IActionResult About()
		{

     AboutModel model = new AboutModel();

     model.ListaTimeline = new List<TimelineSobre>();

     TimelineSobre primeiroSobre = new TimelineSobre();
     primeiroSobre.TituloPrincipal = "1990: A Origem";
     primeiroSobre.Paragrafo = "1996 - Lançamento de Pokémon Red e Green no Japão para Game Boy, desenvolvidos pela Game Freak e publicados pela Nintendo.";
     model.ListaTimeline.Add(primeiroSobre);

     TimelineSobre segundoSobre = new TimelineSobre();
     segundoSobre.TituloPrincipal = "2000: Expansão Global";
     segundoSobre.Paragrafo = "2000 - Lançamento da 2ª geração: Pokémon Gold e Silver.\r\n2002 - 3ª geração: Pokémon Ruby e Sapphire (introduz Hoenn).";
     model.ListaTimeline.Add(segundoSobre);

     TimelineSobre terceiroSobre = new TimelineSobre();
     terceiroSobre.TituloPrincipal = "2010: Reinvenção e Popularização Online";
     terceiroSobre.Paragrafo = "2013 - Pokémon X e Y (estreia no Nintendo 3DS com gráficos 3D).\r\n2016 - Lançamento de Pokémon GO (mobile), realidade aumentada.";
     model.ListaTimeline.Add(terceiroSobre);

     TimelineSobre quartoSobre = new TimelineSobre();
     quartoSobre.TituloPrincipal = "2020: Nova Geração e Mundo Aberto";
     quartoSobre.Paragrafo = "Pokémon Legends: Arceus (2022) — abordagem em mundo semiaberto.\r\nPokémon Scarlet e Violet (região de Paldea) — mundo totalmente aberto.";
     model.ListaTimeline.Add(quartoSobre);

     TimelineSobre quintoSobre = new TimelineSobre();
     quintoSobre.TituloPrincipal = "Atualmente";
     quintoSobre.Paragrafo = "A série Pokémon Horizons (anime com protagonistas inéditos).\r\nContinuidade das atualizações de Pokémon GO e novos jogos spin-off.";
     model.ListaTimeline.Add(quintoSobre);


			model.ListaPerguntasERespostas = new List<PerguntasERespostas>();

			PerguntasERespostas primeiraPergunta = new PerguntasERespostas();
			primeiraPergunta.Perguntas = "Preciso me cadastrar para usar o site?";
			primeiraPergunta.Respostas = "Sim! O cadastro é gratuito e garante que sua coleção fique salva e segura. Você também pode entrar com sua conta do Google.";
			model.ListaPerguntasERespostas.Add(primeiraPergunta);

			PerguntasERespostas segundaPergunta = new PerguntasERespostas();
			segundaPergunta.Perguntas = "Posso adicionar qualquer Pokémon?";
			segundaPergunta.Respostas = "Sim! Você pode adicionar qualquer Pokémon da franquia — desde os clássicos como Bulbasaur até os mais recentes. Também pode criar Pokémons inventados por você!";
			model.ListaPerguntasERespostas.Add(segundaPergunta);

			PerguntasERespostas terceiraPergunta = new PerguntasERespostas();
			terceiraPergunta.Perguntas = "Posso excluir um Pokémon da minha coleção?";
			terceiraPergunta.Respostas = "Basta clicar no ícone de lixeira ou em \"Excluir\" no card do Pokémon. Um aviso de confirmação aparecerá para evitar exclusões acidentais.";
			model.ListaPerguntasERespostas.Add(terceiraPergunta);

			PerguntasERespostas quartaPergunta = new PerguntasERespostas();
			quartaPergunta.Perguntas = "Posso compartilhar minha coleção com amigos?";
			quartaPergunta.Respostas = "Em breve! Estamos desenvolvendo um recurso para você gerar um link público e mostrar sua Pokédex personalizada aos seus amigos.";
			model.ListaPerguntasERespostas.Add(quartaPergunta);

			PerguntasERespostas quintaPergunta = new PerguntasERespostas();
			quintaPergunta.Perguntas = "O site funciona com celular?";
			quintaPergunta.Respostas = "Sim! Toda a plataforma é responsiva, feita com tecnologias modernas como Bootstrap 5, para funcionar bem em celulares, tablets e desktops.";
			model.ListaPerguntasERespostas.Add(quintaPergunta);

			PerguntasERespostas sextaPergunta = new PerguntasERespostas();
			sextaPergunta.Perguntas = "Esse site é oficial da Pokémon Company?";
			sextaPergunta.Respostas = "Não. Este é um projeto feito por fãs, para fãs. Não temos ligação com a Nintendo, Game Freak ou The Pokémon Company.";
			model.ListaPerguntasERespostas.Add(sextaPergunta);

			return View(model);
		}
	}
}
