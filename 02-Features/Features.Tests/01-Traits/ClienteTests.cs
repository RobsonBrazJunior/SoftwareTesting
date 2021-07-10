using Features.Clientes;
using System;
using Xunit;

namespace Features.Tests._01_Traits
{
    public class ClienteTests
    {
        [Fact(DisplayName = "Novo Cliente Válido")]
        [Trait("Categoria","Cliente")]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            // Arrange
            var cliente = new Cliente(
                id: Guid.NewGuid(),
                nome: "Junior",
                sobrenome: "Braz",
                dataNascimento: DateTime.Now.AddYears(-30),
                email: "junior@braz.com",
                ativo: true,
                dataCadastro: DateTime.Now);

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.True(result);
            Assert.Equal(expected: 0, actual: cliente.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria","Cliente")]
        public void Cliente_NovoCliente_DeveEstarInvalido()
        {
            // Arrange
            var cliente = new Cliente(
                id: Guid.NewGuid(),
                nome: "",
                sobrenome: "",
                dataNascimento: DateTime.Now,
                email: "juniorbraz.com",
                ativo: true,
                dataCadastro: DateTime.Now);

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.False(result);
            Assert.NotEqual(expected: 0, actual: cliente.ValidationResult.Errors.Count);
        }
    }
}
