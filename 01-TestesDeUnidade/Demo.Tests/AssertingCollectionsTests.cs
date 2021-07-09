using Xunit;

namespace Demo.Tests
{
    public class AssertingCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Junior", salario: 10000);

            //Assert
            Assert.All(funcionario.Habilidades, action: habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadesBasicas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Junior", salario: 1000);

            //Assert
            Assert.Contains(expected: "Orientação a Objetos", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadesAvancadas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Junior", salario: 1000);

            //Assert
            Assert.DoesNotContain(expected: "Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Junior", salario: 15000);

            var habilidades = new[]
            {
                "Lógica de programação",
                "Orientação a Objetos",
                "Testes",
                "Microservices"
            };

            //Assert
            Assert.Equal(expected: habilidades, actual: funcionario.Habilidades);
        }
    }
}
