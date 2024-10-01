using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_funcionários
{
    internal class Funcionario
    {
        public string Nome;
        public string Setor;
        public string Cargo;
        public int Id;

        public Funcionario(string nome, string setor, string cargo, int id)
        {
            Nome = nome;
            Setor = setor;
            Cargo = cargo;
            Id = id;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \n" + $"Setor: {Setor}\n" + $"Cargo: {Cargo}\n" + $"Id: {Id}\n";
        }
    }
}
