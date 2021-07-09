using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringTools_Unir_RetornarNomeCompleto()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Junior", "Braz");

            // Assert
            Assert.Equal("Junior Braz", nomeCompleto);
        }

        [Fact]
        public void StringTools_Unir_DeveIgnorarCase()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Junior", "Braz");

            // Assert
            Assert.Equal(expected: "JUNIOR BRAZ", actual: nomeCompleto, ignoreCase: true);
        }

        [Fact]
        public void StringTools_Unir_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Junior", "Braz");

            // Assert
            Assert.Contains(expectedSubstring: "nior", actualString: nomeCompleto);
        }

        [Fact]
        public void StringTools_Unir_DeveComecarCom()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Junior", "Braz");

            // Assert
            Assert.StartsWith(expectedStartString: "Ju", actualString: nomeCompleto);
        }

        [Fact]
        public void StringTools_Unir_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Junior", "Braz");

            // Assert
            Assert.EndsWith(expectedEndString: "raz", actualString: nomeCompleto);
        }

        [Fact]
        public void StringTools_Unir_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Junior", "Braz");

            // Assert
            Assert.Matches(expectedRegexPattern:"[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", actualString: nomeCompleto);
        }
    }
}
