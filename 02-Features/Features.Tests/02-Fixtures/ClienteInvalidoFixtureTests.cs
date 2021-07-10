using Xunit;

namespace Features.Tests._02_Fixtures
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteInvalidoFixtureTests
    {
        private readonly ClienteTestsFixture _clienteTestsFixture;

        public ClienteInvalidoFixtureTests(ClienteTestsFixture clienteTestsFixture)
        {
            _clienteTestsFixture = clienteTestsFixture;
        }

        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria", "Cliente Fixture")]
        public void Cliente_NovoCliente_DeveEstarInvalido()
        {
            // Arrange
            var cliente = _clienteTestsFixture.GerarClienteInvalido();

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.False(result);
            Assert.NotEmpty(cliente.ValidationResult.Errors);
        }
    }
}
