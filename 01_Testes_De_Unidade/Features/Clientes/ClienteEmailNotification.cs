using MediatR;

namespace Features.Clientes
{
	public class ClienteEmailNotification : INotification
	{
		public string Origem { get; }
		public string Destino { get; }
		public string Assunto { get; }
		public string Mensagem { get; }

		public ClienteEmailNotification(string origem, string destino, string assunto, string mensagem)
		{
			Origem = origem;
			Destino = destino;
			Assunto = assunto;
			Mensagem = mensagem;
		}
	}
}
