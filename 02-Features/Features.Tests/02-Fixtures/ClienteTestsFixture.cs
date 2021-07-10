using Features.Clientes;
using System;

namespace Features.Tests._02_Fixtures
{
    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            return new Cliente(id: Guid.NewGuid(),
                               nome: "Junior",
                               sobrenome: "Braz",
                               dataNascimento: DateTime.Now.AddYears(-30),
                               email: "junior@braz.com",
                               ativo: true,
                               dataCadastro: DateTime.Now);
        }

        public Cliente GerarClienteInvalido()
        {
            return new Cliente(id: Guid.NewGuid(),
                               nome: "",
                               sobrenome: "",
                               dataNascimento: DateTime.Now,
                               email: "juniorbraz.com",
                               ativo: true,
                               dataCadastro: DateTime.Now);
        }

        public void Dispose()
        {
        }
    }
}
