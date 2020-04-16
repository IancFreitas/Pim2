using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PIM.Funcionarios;
using PIM.ListadeFuncionarios;

namespace PIM.Cadastros
{
    public class Cadastro
    {
        public bool TentativaAcesso(int codigo)
        {
            if (codigo == 1)
            {
                Console.WriteLine("Você possuí acesso para cadastro de Funcionário.");
                return true;
            }
            else
            {
                Console.WriteLine("Você não possuí acesso para cadastro. Entrar em contato com o Administrador.");
                return false;
            }
        }

        public bool Login(string Usuario, string Senha) 
        {
            var usuarios = BasedeDadosFuncionarios.CorpoDocente;
            if (usuarios.Any(x => x.Usuario == Usuario && x.Senha == Senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            var usuarios = BasedeDadosFuncionarios.CorpoDocente;
            if (usuarios.Any(x => x.Usuario != usuario && x.Senha != senha))
            {
                int id = 3;
                Console.WriteLine("Insira os dados do professor");
                Funcionario cadastramento = new Funcionario();
                Console.WriteLine("Insira o CPF");
                cadastramento.Cpf = long.Parse(Console.ReadLine());
                Console.WriteLine("Insira o nome");
                cadastramento.Nome = Console.ReadLine();
                Console.WriteLine("Insira o função");
                cadastramento.Funcao = Console.ReadLine();
                cadastramento.CodigoFuncao = 2;
                cadastramento.CodigoFuncionario = 203;
                cadastramento.Id = (id + 1);
                usuarios.Add(cadastramento);
                id++;
                return true;
            }
            else
            {
                Console.WriteLine("Esse funcionário já existe");
                return false;
            }

        }
        public bool Retirar(string usuario)
        {
            var usuarios = BasedeDadosFuncionarios.CorpoDocente;
            if (usuarios.Any(x => x.Usuario != usuario))
            {
                Funcionario cadastramento = new Funcionario();
                usuarios.Remove(cadastramento);
                return true;
            }
            else
            {
                Console.WriteLine("Esse funcionário não existe");
                return false;
            }

        }

    }
}
