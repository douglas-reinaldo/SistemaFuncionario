using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    internal class SistemaFuncionarios
    {
        public List<Funcionario> sistema = new List<Funcionario>();


        public void AdicionarFuncionario(Funcionario func)
        {
            Console.WriteLine("Adicionando funcionário ao sistema..");
            sistema.Add(func);
            Console.WriteLine("Funcionário adicionado ao sistema com sucesso!");
        }

        public void EditarFuncionario(string nome)
        {
            Funcionario func = sistema.Find(funcionario => funcionario.Nome == nome);
            if (func != null)
            {
                int escolha = Opcao();

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Insira o novo nome: ");
                        string novoNome = Console.ReadLine();
                        func.Nome = novoNome;
                        break;
                    case 2:
                        Console.WriteLine("Insira a nova idade: ");
                        int novaIdade = int.Parse(Console.ReadLine());
                        func.Idade = novaIdade;
                        break;
                    case 3:
                        Console.WriteLine("Insira o novo cargo: ");
                        string novoCargo = Console.ReadLine();
                        func.Cargo = novoCargo;
                        break;
                    case 4:
                        Console.WriteLine("Insira o novo nome: ");
                        double novoSalario = double.Parse(Console.ReadLine());
                        func.Salario = novoSalario;
                        break;
                }
                Console.WriteLine("Edição feita com sucesso!\nDados alterados: ");
                Console.WriteLine(func);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }
        }

        public void ExcuirFuncionario(string nome)
        {
            Funcionario func = sistema.Find(funcionario => funcionario.Nome == nome);
            if (func != null)
            {
                Console.WriteLine("Funcionário Encontrado!\nExcluindo Funcionário..");
                sistema.Remove(func);
                Console.WriteLine("Funcionário Exluido do sistema com sucesso!");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado! ");
            }
        }

        public int Opcao()
        {
            Console.WriteLine("Insira a opção para editar as informações do funcionário: ");
            Console.WriteLine("1 - Nome\n2 - Idade\n3 - Cargo\n4 - Salario");
            int escolha = int.Parse(Console.ReadLine());
            return escolha;
        }

        public void ListarFuncionarios()
        {
            if (sistema.Count == 0)
            {
                Console.WriteLine("Sem funcionários cadastrados! ");
            }
            else
            {
                foreach (Funcionario func in sistema)
                {
                    Console.WriteLine(func);
                }
            }
        }
    }
}
