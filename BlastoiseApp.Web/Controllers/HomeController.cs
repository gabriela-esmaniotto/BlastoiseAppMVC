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

			model.TextoInicio = "Sua Aventura Pokem�n Come�a Aqui";

			List<PokemonListDTO> pokemons = await _pokemonService.GetAllAsync();
			model.ListaPokemon = pokemons;

			model.ListaCard = new List<CardHome>();

			CardHome primeiroCard = new CardHome();
			primeiroCard.Titulo = "Pocket Monsters";
			primeiroCard.Texto = "O nome �Pok�mon� � uma abrevia��o de Pocket Monsters (\"monstros de bolso\"), como eram chamados no Jap�o no lan�amento original.";
			model.ListaCard.Add(primeiroCard);

			CardHome segundoCard = new CardHome();
			segundoCard.Titulo = "+ 1.000 Pok�mons";
			segundoCard.Texto = "Desde 1996, o n�mero de Pok�mon s� cresceu. Com as gera��es mais recentes, j� passamos de 1.000 esp�cies diferentes!";
			model.ListaCard.Add(segundoCard);

			CardHome terceiroCard = new CardHome();
			terceiroCard.Titulo = "Guinness World Records";
			terceiroCard.Texto = "A franquia Pok�mon tem v�rios recordes, incluindo o jogo de RPG mais vendido na hist�ria do entretenimento (Pok�mon Red/Blue/Green).";
			model.ListaCard.Add(terceiroCard);

			CardHome quartoCard = new CardHome();
			quartoCard.Titulo = "MissingNo.";
			quartoCard.Texto = "Abrevia��o de �Missing Number� � um Pok�mon glitched que aparece nos jogos Pok�mon Red e Blue, resultado de falhas na programa��o.";
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
     primeiroSobre.Paragrafo = "1996 - Lan�amento de Pok�mon Red e Green no Jap�o para Game Boy, desenvolvidos pela Game Freak e publicados pela Nintendo.";
     model.ListaTimeline.Add(primeiroSobre);

     TimelineSobre segundoSobre = new TimelineSobre();
     segundoSobre.TituloPrincipal = "2000: Expans�o Global";
     segundoSobre.Paragrafo = "2000 - Lan�amento da 2� gera��o: Pok�mon Gold e Silver.\r\n2002 - 3� gera��o: Pok�mon Ruby e Sapphire (introduz Hoenn).";
     model.ListaTimeline.Add(segundoSobre);

     TimelineSobre terceiroSobre = new TimelineSobre();
     terceiroSobre.TituloPrincipal = "2010: Reinven��o e Populariza��o Online";
     terceiroSobre.Paragrafo = "2013 - Pok�mon X e Y (estreia no Nintendo 3DS com gr�ficos 3D).\r\n2016 - Lan�amento de Pok�mon GO (mobile), realidade aumentada.";
     model.ListaTimeline.Add(terceiroSobre);

     TimelineSobre quartoSobre = new TimelineSobre();
     quartoSobre.TituloPrincipal = "2020: Nova Gera��o e Mundo Aberto";
     quartoSobre.Paragrafo = "Pok�mon Legends: Arceus (2022) � abordagem em mundo semiaberto.\r\nPok�mon Scarlet e Violet (regi�o de Paldea) � mundo totalmente aberto.";
     model.ListaTimeline.Add(quartoSobre);

     TimelineSobre quintoSobre = new TimelineSobre();
     quintoSobre.TituloPrincipal = "Atualmente";
     quintoSobre.Paragrafo = "A s�rie Pok�mon Horizons (anime com protagonistas in�ditos).\r\nContinuidade das atualiza��es de Pok�mon GO e novos jogos spin-off.";
     model.ListaTimeline.Add(quintoSobre);


			model.ListaPerguntasERespostas = new List<PerguntasERespostas>();

			PerguntasERespostas primeiraPergunta = new PerguntasERespostas();
			primeiraPergunta.Perguntas = "Preciso me cadastrar para usar o site?";
			primeiraPergunta.Respostas = "Sim! O cadastro � gratuito e garante que sua cole��o fique salva e segura. Voc� tamb�m pode entrar com sua conta do Google.";
			model.ListaPerguntasERespostas.Add(primeiraPergunta);

			PerguntasERespostas segundaPergunta = new PerguntasERespostas();
			segundaPergunta.Perguntas = "Posso adicionar qualquer Pok�mon?";
			segundaPergunta.Respostas = "Sim! Voc� pode adicionar qualquer Pok�mon da franquia � desde os cl�ssicos como Bulbasaur at� os mais recentes. Tamb�m pode criar Pok�mons inventados por voc�!";
			model.ListaPerguntasERespostas.Add(segundaPergunta);

			PerguntasERespostas terceiraPergunta = new PerguntasERespostas();
			terceiraPergunta.Perguntas = "Posso excluir um Pok�mon da minha cole��o?";
			terceiraPergunta.Respostas = "Basta clicar no �cone de lixeira ou em \"Excluir\" no card do Pok�mon. Um aviso de confirma��o aparecer� para evitar exclus�es acidentais.";
			model.ListaPerguntasERespostas.Add(terceiraPergunta);

			PerguntasERespostas quartaPergunta = new PerguntasERespostas();
			quartaPergunta.Perguntas = "Posso compartilhar minha cole��o com amigos?";
			quartaPergunta.Respostas = "Em breve! Estamos desenvolvendo um recurso para voc� gerar um link p�blico e mostrar sua Pok�dex personalizada aos seus amigos.";
			model.ListaPerguntasERespostas.Add(quartaPergunta);

			PerguntasERespostas quintaPergunta = new PerguntasERespostas();
			quintaPergunta.Perguntas = "O site funciona com celular?";
			quintaPergunta.Respostas = "Sim! Toda a plataforma � responsiva, feita com tecnologias modernas como Bootstrap 5, para funcionar bem em celulares, tablets e desktops.";
			model.ListaPerguntasERespostas.Add(quintaPergunta);

			PerguntasERespostas sextaPergunta = new PerguntasERespostas();
			sextaPergunta.Perguntas = "Esse site � oficial da Pok�mon Company?";
			sextaPergunta.Respostas = "N�o. Este � um projeto feito por f�s, para f�s. N�o temos liga��o com a Nintendo, Game Freak ou The Pok�mon Company.";
			model.ListaPerguntasERespostas.Add(sextaPergunta);

			return View(model);
		}
	}
}
