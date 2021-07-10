using Xunit;

namespace Features.Tests._03_Order
{
    [TestCaseOrderer("Features.Tests._03_Order.PriorityOrderer", "Features.Tests")]
    public class OrdemTestes
    {
        private static bool _teste1Chamado;
        private static bool _teste2Chamado;
        private static bool _teste3Chamado;
        private static bool _teste4Chamado;

        public static bool Teste1Chamado { get => _teste1Chamado; set => _teste1Chamado = value; }
        public static bool Teste2Chamado { get => _teste2Chamado; set => _teste2Chamado = value; }
        public static bool Teste3Chamado { get => _teste3Chamado; set => _teste3Chamado = value; }
        public static bool Teste4Chamado { get => _teste4Chamado; set => _teste4Chamado = value; }

        [Fact(DisplayName = "Teste 04"), TestPriority(3)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste04()
        {
            Teste4Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.True(Teste1Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 01"), TestPriority(2)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste01()
        {
            Teste1Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.False(Teste4Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 03"), TestPriority(1)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste03()
        {
            Teste3Chamado = true;

            Assert.False(Teste1Chamado);
            Assert.False(Teste2Chamado);
            Assert.False(Teste4Chamado);
        }

        [Fact(DisplayName = "Teste 02"), TestPriority(4)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste02()
        {
            Teste2Chamado = true;

            Assert.True(Teste3Chamado);
            Assert.True(Teste4Chamado);
            Assert.True(Teste1Chamado);
        }
    }
}
