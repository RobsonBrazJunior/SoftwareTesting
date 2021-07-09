using System;
using System.Collections.Generic;

namespace Demo
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; private set; }

        public NivelProfissional NivelProfissional { get; private set; }

        public IList<string> Habilidades { get; private set; }

        public Funcionario(string nome, decimal salario)
        {
            Nome = string.IsNullOrEmpty(nome) ? "Fulano" : nome;
            DefinirSalario(salario);
            DefinirHabilidades();
        }

        private void DefinirSalario(decimal salario)
        {
            if (salario < 500) throw new Exception("Salário inferior ao permitido!");

            Salario = salario;
            if (salario < 2000) NivelProfissional = NivelProfissional.JUNIOR;
            else if (salario >= 2000 && salario < 8000) NivelProfissional = NivelProfissional.PLENO;
            else if (salario >= 8000) NivelProfissional = NivelProfissional.SENIOR;
        }

        private void DefinirHabilidades()
        {
            var habilidadesBasicas = new List<string>()
            {
                "Lógica de programação",
                "Orientação a Objetos"
            };

            Habilidades = habilidadesBasicas;

            switch (NivelProfissional)
            {
                case NivelProfissional.PLENO:
                    Habilidades.Add("Testes");
                    break;
                case NivelProfissional.SENIOR:
                    Habilidades.Add("Testes");
                    Habilidades.Add("Microservices");
                    break;
            }
        }
    }
}
