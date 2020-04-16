using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIM.Funcionarios;

namespace PIM.ListadeFuncionarios
{
    public class BasedeDadosFuncionarios
    {
        public static List<Funcionario> CorpoDocente = new List<Funcionario>()
        {
            new Funcionarios.Funcionario {Nome="Ian", Cpf=12345678911, CodigoFuncionario=101, Id=11, Funcao="Desenvolvedor", CodigoFuncao=1, Usuario="Iandev", Senha="senha123"},
            new Funcionarios.Funcionario {Nome="Fernanda", Cpf=45678912322, CodigoFuncionario=102, Id=12, Funcao="Diretora", CodigoFuncao=1, Usuario="Fedir", Senha="senha456"},
            new Funcionarios.Funcionario {Nome="Helio", Cpf=11987654321, CodigoFuncionario=201, Id=21, Funcao="Professor", CodigoFuncao=2, Usuario="heliofessor",Senha="senha789"},
            new Funcionarios.Funcionario {Nome="Fernanda", Cpf=45678912322, CodigoFuncionario=202, Id=22, Funcao="Professor", CodigoFuncao=2, Usuario="Ferssora",Senha="senha1011"},
            new Funcionarios.Funcionario {Nome="Teste", Cpf=00000000000, CodigoFuncionario=000, Id=10, Funcao="Testar", CodigoFuncao=1, Usuario="teste",Senha="teste"}
        };
        public static int NumerodeAdministradores()
        {
            return CorpoDocente.OfType<Funcionario>().Where(x => x.CodigoFuncao == 1).Count();
        }
        public static int NumerodeProfessores()
        {
            return CorpoDocente.OfType<Funcionario>().Where(x => x.CodigoFuncao == 2).Count();
        }
        public static int NumeroTotal()
        {
            return CorpoDocente.Count();
        }
    }
}
