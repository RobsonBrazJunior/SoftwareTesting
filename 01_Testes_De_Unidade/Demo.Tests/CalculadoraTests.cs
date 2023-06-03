using Xunit;

namespace Demo.Tests
{
	public class CalculadoraTests
	{
		[Fact]
		public void Calculadora_Somar_RetornarValorSoma()
		{
			// Arrange
			var calculadora = new Calculadora();

			// Act
			var resultado = calculadora.Somar(2, 2);

			// Assert
			Assert.Equal(4, resultado);
		}

		[Theory]
		[InlineData(1, 1, 2)]
		[InlineData(2, 2, 4)]
		[InlineData(4, 2, 6)]
		[InlineData(7, 3, 10)]
		[InlineData(6, 6, 12)]
		[InlineData(9, 9, 18)]
		[InlineData(5, 8, 13)]
		public void Calculadora_Somar_RetornarValoresSomaCorretos(int v1, int v2, int total)
		{
			// Arrange
			var calculadora = new Calculadora();

			// Act
			var resultado = calculadora.Somar(v1, v2);

			// Assert
			Assert.Equal(total, resultado);
		}
	}
}
