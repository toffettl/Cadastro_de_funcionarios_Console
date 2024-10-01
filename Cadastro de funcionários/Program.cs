using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_funcionários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastro c = new Cadastro();
            string opcao;

            do
            {
                Console.WriteLine("Digite 1 para adicionar um funcionário");
                Console.WriteLine("Digite 2 para listar os funcionários");
                Console.WriteLine("Digite 3 para apagar um funcionário");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do funcionário");
                        string nomeFuncionario = Console.ReadLine();
                        Console.WriteLine("Digite o setor do funcionário");
                        string setorFuncionario = Console.ReadLine();
                        Console.WriteLine("Digite o cargo do funcionário");
                        string cargoFuncionario = Console.ReadLine();
                        Console.WriteLine("Digite o Id do funcionário");
                        int idFuncionario = Convert.ToInt32(Console.ReadLine());
                        Funcionario f = new Funcionario(nomeFuncionario, setorFuncionario, cargoFuncionario, idFuncionario);
                        c.cadastrarFuncionario(idFuncionario, f);
                        break;

                    case "2":
                        c.exibirListaFuncionario();
                        break;

                    case "3":
                        Console.WriteLine("Digite o id:");
                        int valorId = Convert.ToInt32((Console.ReadLine()));
                        c.removerFuncionario(valorId);
                        break;
                }
            } while (opcao != "90");
        }
    }
}
