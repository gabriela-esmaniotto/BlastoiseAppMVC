namespace BlastoiseApp.Web.Models
{
	public class Cadeira
	{
		public Cadeira(string modelo, string cor)
		{
			Modelo = modelo;
			Cor = cor;
			Ativo = true;
			DataDeCriacao = DateTime.Now;
			Gamer = false;
		}
		public string Modelo { get; set; }
		public bool Gamer { get; set; }
		public decimal Tamanho { get; set; }
		public string Cor { get; set; }

		public bool Ativo { get; set; }
		public DateTime DataDeCriacao { get; set; }

		public List<PecaCadeira> Pecas { get; set; }
	}
}
