using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            SistemaFuncionarios sistema = new SistemaFuncionarios();
            while (on)
            {
                int resposta = Menu();

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("------ Inserir Funcionário ------");
                        Console.Write("Insira o nome do funcionário: ");
                        string nome = Console.ReadLine();

                        Console.Write("Insira a idade do funcionário: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Insira o cargo do funcionário: ");
                        string cargo = Console.ReadLine();

                        Console.Write("Insira o salário do funcionario: ");
                        double salario = double.Parse(Console.ReadLine());

                        Funcionario funcionario = new Funcionario(nome, idade, cargo, salario);
                        sistema.AdicionarFuncionario(funcionario);

                        break;

                    case 2:
                        Console.Write("Insira o nome do funcionário: ");
                        string func = Console.ReadLine();
                        sistema.EditarFuncionario(func);
                        break;
                    case 3:
                        Console.Write("Insira o nome do funcionário que deseja excluir: ");
                        string exNome = Console.ReadLine();
                        sistema.ExcuirFuncionario(exNome);
                        break;
                    case 4:
                        Console.WriteLine("Listando Funcionários: ");
                        sistema.ListarFuncionarios();
                        break;
                    case 5:
                        on = false;
                        break;
                }
            }
        }
        static public int Menu()
        {
            Console.WriteLine("------------- Menú -------------");
            Console.WriteLine("1 - Adicionar Funcionário\n2 - Editar informações do Funcionário\n3 - Excluir Funcionário\n4 - Listar todos funcionários\n5 - Sair do Programa");
            int inteiro = int.Parse(Console.ReadLine());
            return inteiro;
        }
    }
}
