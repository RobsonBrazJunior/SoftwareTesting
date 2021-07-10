using Xunit;

namespace Features.Tests._02_Fixtures
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteValidoFixtureTests
    {
        private readonly ClienteTestsFixture _clienteTestsFixture;

        public ClienteValidoFixtureTests(ClienteTestsFixture clienteTestsFixture)
        {
            _clienteTestsFixture = clienteTestsFixture;
        }

        [Fact(DisplayName = "Novo Cliente Válido")]
        [Trait("Categoria","Cliente Fixture")]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            // Arrange
            var cliente = _clienteTestsFixture.GerarClienteValido();

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.True(result);
            Assert.Empty(cliente.ValidationResult.Errors);
        }
    }
}
