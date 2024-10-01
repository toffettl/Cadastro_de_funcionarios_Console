using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_funcionários
{
    internal class Cadastro
    {
        Dictionary<int, Funcionario> listaFuncionarios = new Dictionary<int, Funcionario>();

        public void cadastrarFuncionario(int Id, Funcionario funcionario)
        {
            listaFuncionarios.Add(Id, funcionario);
        }

        public void exibirListaFuncionario()
        {
            foreach(KeyValuePair<int, Funcionario> item in listaFuncionarios)
            {
                Console.WriteLine(item.Value);
            }
        }

        public void removerFuncionario(int valorId)
        {
            if(listaFuncionarios.ContainsKey(valorId))
            {
                listaFuncionarios.Remove(valorId);
            }
            else
            {
                Console.WriteLine("Esse Id não existe");
            }
        }
    }
}
