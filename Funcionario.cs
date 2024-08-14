using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemaFuncionarios
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, string cargo, double salario)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário: {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
