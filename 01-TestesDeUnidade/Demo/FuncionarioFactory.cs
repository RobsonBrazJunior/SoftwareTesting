namespace Demo
{
    public class FuncionarioFactory
    {
        public static Funcionario Criar(string nome, decimal salario)
        {
            return new Funcionario(nome, salario);
        }
    }
}
