using Xunit;

namespace Demo.Tests
{
    public class AssertingRangesTests
    {
        [Theory]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8000)]
        [InlineData(15000)]
        public void Funcionario_Salario_FaixasSalariaisDevemRespeitarNivelProfissional(decimal salario)
        {
            // Arrange & Act
            var funcionario = new Funcionario("Junior", salario);

            if (funcionario.NivelProfissional == NivelProfissional.JUNIOR)
            {
                Assert.InRange(actual: funcionario.Salario, low: 500, high: 1999);
            }

            if (funcionario.NivelProfissional == NivelProfissional.PLENO)
            {
                Assert.InRange(actual: funcionario.Salario, low: 2000, high: 7999);
            }

            if (funcionario.NivelProfissional == NivelProfissional.SENIOR)
            {
                Assert.InRange(actual: funcionario.Salario, low: 8000, high: decimal.MaxValue);
            }

            Assert.NotInRange(actual: funcionario.Salario, low: 0, high: 499);
        }
    }
}
